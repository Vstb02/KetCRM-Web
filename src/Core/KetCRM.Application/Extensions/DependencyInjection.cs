using KetCRM.Application.Common.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace KetCRM.Application.Extensions
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
