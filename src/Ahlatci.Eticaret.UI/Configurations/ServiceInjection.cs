using Ahlatci.Eticaret.UI.Services.Abstraction;
using Ahlatci.Eticaret.UI.Services.Implementation;

namespace Ahlatci.Eticaret.UI.Configurations
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IRestService, RestService>();
            
            return services;
        }
    }
}
