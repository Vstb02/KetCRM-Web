using KetCRM.Application.Models;
using KetCRM.Application.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Common.Interfaces.Persons
{
    public interface IPersonService
    {
        Task<Result<PersonDto>> GetPersonById(Guid PersonId);
        Task<Result<PersonListDto>> GetAllPerson();
        Task<Result<Guid>> CreatePerson(CreatePersonDto personDto);
        Task<Result<Guid>> UpdatePerson(UpdatePersonDto personDto, Guid PersonId);
        Task<Result<Guid>> DeletePerson(Guid PersonId);
    }
}
