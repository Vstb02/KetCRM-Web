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
        Task<PersonDto> GetPersonById(Guid PersonId);
        Task<PersonListDto> GetAllPerson();
        Task<Guid> CreatePerson(CreatePersonDto personDto);
        Task<Guid> UpdatePerson(UpdatePersonDto personDto, Guid PersonId);
        Task<Guid> DeletePerson(Guid PersonId);
    }
}
