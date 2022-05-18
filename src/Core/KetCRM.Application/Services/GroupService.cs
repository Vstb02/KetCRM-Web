using AutoMapper;
using KetCRM.Application.Common.Interfaces;
using KetCRM.Application.Common.Interfaces.Groups;
using KetCRM.Application.Models;
using KetCRM.Application.Models.Groups;
using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<GroupService> _logger;
        private readonly IMapper _mapper;

        public GroupService(ILogger<GroupService> logger,
            IApplicationDbContext context,
            IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;

        }

        public async Task<Result<Guid>> CreateGroup(CreateGroupDto GroupDto)
        {
            var group = _mapper.Map<Group>(GroupDto);

            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(group.Id);
        }

        public async Task<Result<Guid>> DeleteGroup(Guid GroupId)
        {
            var group = await _context.Groups.FindAsync(GroupId);

            if (group == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Group)}\" ({GroupId}) не найдена.");
                return Result<Guid>.Failure("Группа не найдена");
            }

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(group.Id);
        }

        public async Task<Result<GroupListDto>> GetAllGroup()
        {
            var group = await _context.Groups.ToListAsync();

            if (group == null)
            {
                _logger.LogWarning($"Список {nameof(GroupListDto)} не найден");
                return Result<GroupListDto>.Failure("Группы не найдены");
            }

            GroupListDto groupList = new GroupListDto();
            
            foreach (var Item in group)
            {
                groupList.List.Add(_mapper.Map<GroupDto>(Item));
            }

            return Result<GroupListDto>.Success(groupList);
        }

        public async Task<Result<GroupDto>> GetGroupById(Guid GroupId)
        {
            var group = await _context.Groups.FindAsync(GroupId);

            if (group == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Group)}\" ({GroupId}) не найдена.");
                return Result<GroupDto>.Failure("Группа не найдена");
            }

            var groupDto = _mapper.Map<GroupDto>(group);

            return Result<GroupDto>.Success(groupDto);
        }

        public async Task<Result<Guid>> UpdateGroup(UpdateGroupDto GroupDto, Guid GroupId)
        {
            var group = await _context.Groups.FindAsync(GroupId);

            if(group == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Group)}\" ({GroupId}) не найдена.");
                return Result<Guid>.Failure("Группа не найдена");
            }

            group = _mapper.Map<Group>(GroupDto);

            _context.Groups.Update(group);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(group.Id);
        }
    }
}
