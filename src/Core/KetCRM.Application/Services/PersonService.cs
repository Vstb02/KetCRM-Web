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

            var address = new Address()
            {
                Id = Guid.NewGuid(),
                City = personDto.City,
                ActualAddress = personDto.ActualAddress,
                Country = personDto.Country,
                Flat = personDto.Flat,
                House = personDto.House,
                Region = personDto.Region,
                Street = personDto.Street,
                PersonId = person.Id
            };

            await _context.Addresses.AddAsync(address);
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
                var address = await _context.Addresses.Where(x => x.PersonId == Item.Id).FirstOrDefaultAsync();

                var personItem = _mapper.Map<PersonDto>(Item);

                if (address != null)
                {
                    personItem.ActualAddress = address.ActualAddress;
                    personItem.Country = address.Country;
                    personItem.City = address.City;
                    personItem.House = address.House;
                    personItem.Flat = address.Flat;
                    personItem.Region = address.Region;
                    personItem.Street = address.Street;
                }

                personList.PersonList.Add(personItem);
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

            var address = await _context.Addresses.Where(x => x.PersonId == person.Id).FirstOrDefaultAsync();

            var personDto = _mapper.Map<PersonDto>(person);

            if(address != null)
            {
                personDto.ActualAddress = address.ActualAddress;
                personDto.Country = address.Country;
                personDto.City = address.City;
                personDto.House = address.House;
                personDto.Flat = address.Flat;
                personDto.Region = address.Region;
                personDto.Street = address.Street;  
            }

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

            var address = await _context.Addresses.Where(x => x.PersonId == person.Id).FirstOrDefaultAsync();

            if (address != null)
            {
                address.ActualAddress = personDto.ActualAddress;
                address.Country = personDto.Country;
                address.City = personDto.City;
                address.House = personDto.House;
                address.Flat = personDto.Flat;
                address.Region = personDto.Region;
                address.Street = personDto.Street;
            }

            person = _mapper.Map<Person>(personDto);

            _context.Persons.Update(person);
            await _context.SaveChangesAsync();

            return Result<Guid>.Success(person.Id);
        }
    }
}
