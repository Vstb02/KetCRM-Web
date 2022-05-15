using KetCRM.Shared.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace KetCRM.Shared.Extensions
{
    public static class DependencyInjection
    {
        public static void AddShared(this IServiceCollection services)
        {
            services.AddScoped(typeof(ILogger<>), typeof(Logger<>));
        }
    }
}
