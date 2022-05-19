using KetCRM.Application.Models;
using KetCRM.Application.Models.Specializations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Common.Interfaces.Specializations
{
    public interface ISpecializationService
    {
        Task<Result<SpecializationDto>> GetSpecializationById(Guid SpecializationId);
        Task<Result<SpecializationListDto>> GetAllSpecialization();
        Task<Result<Guid>> CreateSpecialization(CreateSpecializationDto SpecializationDto);
        Task<Result<Guid>> DeleteSpecialization(Guid SpecializationId);
        Task<Result<Guid>> UpdateSpecialization(UpdateSpecializationDto SpecializationDto, Guid SpecializationId);
    }
}
