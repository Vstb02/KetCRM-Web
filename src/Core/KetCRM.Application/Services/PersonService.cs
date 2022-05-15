﻿using AutoMapper;
using KetCRM.Application.Common.Exceptions;
using KetCRM.Application.Common.Interfaces;
using KetCRM.Application.Common.Interfaces.Persons;
using KetCRM.Application.Models;
using KetCRM.Application.Models.Persons;
using KetCRM.Domain.Entities;
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
        public PersonService(IApplicationDbContext context, 
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Guid> CreatePerson(CreatePersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);

            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();

            return person.Id;
        }

        public async Task<Guid> DeletePerson(Guid PersonId)
        {
            var person = await _context.Persons.FindAsync(PersonId);

            if (person == null)
            {
                throw new NotFoundException(nameof(Person), PersonId);
            }

            _context.Persons.Remove(person);

            await _context.SaveChangesAsync();

            return PersonId;
        }

        public async Task<PersonListDto> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public async Task<PersonDto> GetPersonById(Guid PersonId)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> UpdatePerson(UpdatePersonDto personDto)
        {
            throw new NotImplementedException();
        }
    }
}
