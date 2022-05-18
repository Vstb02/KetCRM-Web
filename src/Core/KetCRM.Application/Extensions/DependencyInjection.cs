using KetCRM.Application.Common.Interfaces.Departmnt;
using KetCRM.Application.Common.Interfaces.Groups;
using KetCRM.Application.Common.Interfaces.Persons;
using KetCRM.Application.Common.Mapping;
using KetCRM.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KetCRM.Application.Extensions
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IDepartmentSerivce, DepartmentService>();
        }
    }
}
