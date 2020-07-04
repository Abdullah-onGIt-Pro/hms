using Microsoft.Extensions.DependencyInjection;
using hms.BO;
namespace hms
{
    public static class BOServices
    {
        public static void AddScoped(this IServiceCollection services)
        {
            services.AddScoped<AccountBO>();
            services.AddScoped<BaseBO>();
        }
    }
}