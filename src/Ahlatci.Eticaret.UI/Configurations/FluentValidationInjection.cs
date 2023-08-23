using Ahlatci.Eticaret.UI.Validators.Accounts;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Ahlatci.Eticaret.UI.Configurations
{
    public static class FluentValidationInjection
    {
        public static IServiceCollection AddFluentValidationService(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();

            services.AddValidatorsFromAssemblyContaining(typeof(LoginValidator));

            return services;
        }
    }
}
