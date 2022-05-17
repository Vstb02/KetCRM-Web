using AutoMapper;
using KetCRM.Application.Common.Exceptions;
using KetCRM.Application.Common.Interfaces;
using KetCRM.Application.Common.Interfaces.Persons;
using KetCRM.Application.Models;
using KetCRM.Application.Models.Persons;
using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonService> _logger;
        public PersonService(IApplicationDbContext context, 
            IMapper mapper,
            ILogger<PersonService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<Result<Guid>> CreatePerson(CreatePersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);

            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(person.Id);
        }

        public async Task<Result<Guid>> DeletePerson(Guid PersonId)
        {
            var person = await _context.Persons.FindAsync(PersonId);

            if (person == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Person)}\" ({PersonId}) не найдена.");
                return Result<Guid>.Failure($"Пользователь не найден");
            }

            _context.Persons.Remove(person);

            await _context.SaveChangesAsync();

            return Result<Guid>.Success(person.Id);
        }

        public async Task<Result<PersonListDto>> GetAllPerson()
        {
            var person = await _context.Persons.ToListAsync();

            if (person == null)
            {
                _logger.LogWarning($"Список {nameof(PersonListDto)} не найден");
                return Result<PersonListDto>.Failure($"Ничего не найдено");
            }

            PersonListDto personList = new PersonListDto();

            foreach (var Item in person)
            {
                personList.PersonList.Add(_mapper.Map<PersonDto>(Item));
            }

            return Result<PersonListDto>.Success(personList);
        }

        public async Task<Result<PersonDto>> GetPersonById(Guid PersonId)
        {
            var person = await _context.Persons.FindAsync(PersonId);

            if (person == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Person)}\" ({PersonId}) не найдена.");
                return Result<PersonDto>.Failure($"Пользователь не найден");
            }

            var personDto = _mapper.Map<PersonDto>(person);

            return Result<PersonDto>.Success(personDto);
        }

        public async Task<Result<Guid>> UpdatePerson(UpdatePersonDto personDto, Guid PersonId)
        {
            var person = await _context.Persons.FindAsync(PersonId);

            if (person == null)
            {
                _logger.LogWarning($"Сущность \"{nameof(Person)}\" ({PersonId}) не найдена.");
                return Result<Guid>.Failure($"Пользователь не найден");
            }

            var newPerson = _mapper.Map<Person>(personDto);

            _context.Persons.Update(newPerson);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(newPerson.Id);
        }
    }
}
