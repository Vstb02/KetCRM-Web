using AutoMapper;
using KetCRM.Application.Common.Interfaces;
using KetCRM.Application.Common.Interfaces.Specializations;
using KetCRM.Application.Models;
using KetCRM.Application.Models.Specializations;
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
    public class SpecializationService : ISpecializationService
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<SpecializationService> _logger;

        public SpecializationService(IApplicationDbContext context, 
            IMapper mapper, 
            ILogger<SpecializationService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Result<Guid>> CreateSpecialization(CreateSpecializationDto SpecializationDto)
        {
            var specialization = _mapper.Map<Specialization>(SpecializationDto);

            await _context.Specializations.AddAsync(specialization);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(specialization.Id);
        }

        public async Task<Result<Guid>> DeleteSpecialization(Guid SpecializationId)
        {
            var specialization = await _context.Specializations.FindAsync(SpecializationId);

            if (specialization == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Specialization)}\" ({SpecializationId}) не найдена.");
                return Result<Guid>.Failure("Специализация не найдена");
            }

            _context.Specializations.Remove(specialization);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(specialization.Id);
        }

        public async Task<Result<SpecializationListDto>> GetAllSpecialization()
        {
            var specializations = await _context.Specializations.ToListAsync();

            if (specializations == null)
            {
                _logger.LogWarning($"Список {nameof(SpecializationListDto)} не найден");
                return Result<SpecializationListDto>.Failure($"Ничего не найдено");
            }

            SpecializationListDto specializationList = new SpecializationListDto();

            foreach (var Item in specializations)
            {
                specializationList.List.Add(_mapper.Map<SpecializationDto>(Item));
            }

            return Result<SpecializationListDto>.Success(specializationList);
        }

        public async Task<Result<SpecializationDto>> GetSpecializationById(Guid SpecializationId)
        {
            var specialization = await _context.Specializations.FindAsync(SpecializationId);

            if (specialization == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Specialization)}\" ({SpecializationId}) не найдена.");
                Result<SpecializationDto>.Failure("Специализация не найдена");
            }

            var specializationDto = _mapper.Map<SpecializationDto>(specialization);

            return Result<SpecializationDto>.Success(specializationDto);
        }

        public async Task<Result<Guid>> UpdateSpecialization(UpdateSpecializationDto SpecializationDto, Guid SpecializationId)
        {
            var specialization = await _context.Specializations.FindAsync(SpecializationId);

            if (specialization == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Specialization)}\" ({SpecializationId}) не найдена.");
                return Result<Guid>.Failure("Специализация не найдена");
            }

            specialization = _mapper.Map<Specialization>(SpecializationDto);

            _context.Specializations.Update(specialization);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(SpecializationId);
        }
    }
}
