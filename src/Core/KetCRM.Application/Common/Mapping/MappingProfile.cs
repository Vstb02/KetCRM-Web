using AutoMapper;
using KetCRM.Application.Models.Departments;
using KetCRM.Application.Models.Groups;
using KetCRM.Application.Models.Persons;
using KetCRM.Application.Models.Specializations;
using KetCRM.Domain.Entities;

namespace KetCRM.Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreatePersonDto, Person>();
            CreateMap<UpdatePersonDto, Person>();
            CreateMap<PersonDto, Person>().ReverseMap();

            CreateMap<CreateGroupDto, Group>();
            CreateMap<UpdateGroupDto, Group>();
            CreateMap<GroupDto, Group>().ReverseMap();

            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();
            CreateMap<DepartmentDto, Department>().ReverseMap();

            CreateMap<CreateSpecializationDto, Specialization>();
            CreateMap<UpdateSpecializationDto, Specialization>();
            CreateMap<SpecializationDto, Specialization>().ReverseMap();
        }
    }
}
