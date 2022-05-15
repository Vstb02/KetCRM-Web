using AutoMapper;
using KetCRM.Application.Models.Persons;
using KetCRM.Domain.Entities;

namespace KetCRM.Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreatePersonDto, Person>();
        }
    }
}
