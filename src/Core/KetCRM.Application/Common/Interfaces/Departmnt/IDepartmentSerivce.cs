using KetCRM.Application.Models;
using KetCRM.Application.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Common.Interfaces.Departmnt
{
    public interface IDepartmentSerivce
    {
        Task<Result<DepartmentDto>> GetDepartmentById(Guid DepartmentId);
        Task<Result<DepartmentListDto>> GetAllDepartment();
        Task<Result<Guid>> CreateDepartment(CreateDepartmentDto DepartmetnDto);
        Task<Result<Guid>> DeleteDepartment(Guid DepartmentId);
        Task<Result<Guid>> UpdateDepartment(UpdateDepartmentDto DepartmentDto, Guid DepartmentId);
    }
}
