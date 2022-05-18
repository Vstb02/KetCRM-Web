using AutoMapper;
using KetCRM.Application.Common.Interfaces;
using KetCRM.Application.Common.Interfaces.Departmnt;
using KetCRM.Application.Models;
using KetCRM.Application.Models.Departments;
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
    public class DepartmentService : IDepartmentSerivce
    {
        private readonly IApplicationDbContext _context;

        public DepartmentService(IApplicationDbContext context, 
            IMapper mapper, 
            ILogger<DepartmentService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        private readonly IMapper _mapper;
        private readonly ILogger<DepartmentService> _logger;
        public async Task<Result<Guid>> CreateDepartment(CreateDepartmentDto DepartmetnDto)
        {
            var department = _mapper.Map<Department>(DepartmetnDto);

            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(department.Id);
        }

        public async Task<Result<Guid>> DeleteDepartment(Guid DepartmentId)
        {
            var department = await _context.Departments.FindAsync(DepartmentId);

            if (department == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Department)}\" ({DepartmentId}) не найдена.");
                return Result<Guid>.Failure("Отделение не найдено");
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(department.Id);
        }

        public async Task<Result<DepartmentListDto>> GetAllDepartment()
        {
            var departments = await _context.Departments.ToListAsync();

            if (departments == null)
            {
                _logger.LogWarning($"Список {nameof(DepartmentListDto)} не найден");
                return Result<DepartmentListDto>.Failure("Отделения не найдены");
            }

            DepartmentListDto departmentList = new DepartmentListDto();

            foreach (var Item in departments)
            {
                departmentList.List.Add(_mapper.Map<DepartmentDto>(Item));
            }

            return Result<DepartmentListDto>.Success(departmentList);
        }

        public async Task<Result<DepartmentDto>> GetDepartmentById(Guid DepartmentId)
        {
            var department = await _context.Departments.FindAsync(DepartmentId);

            if (department == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Department)}\" ({DepartmentId}) не найдена.");
                return Result<DepartmentDto>.Failure("Отделение не найдено");
            }

            var departmentDto = _mapper.Map<DepartmentDto>(department);

            return Result<DepartmentDto>.Success(departmentDto);
        }

        public async Task<Result<Guid>> UpdateDepartment(UpdateDepartmentDto DepartmentDto, Guid DepartmentId)
        {
            var department = await _context.Departments.FindAsync(DepartmentId);

            if (department == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Department)}\" ({DepartmentId}) не найдена.");
                return Result<Guid>.Failure("Группа не найдена");
            }

            department = _mapper.Map<Department>(DepartmentDto);

            _context.Departments.Update(department);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(department.Id);
        }
    }
}
