﻿using Ahlatci.Eticaret.UI.Authorization;
using Ahlatci.Eticaret.UI.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ahlatci.Eticaret.UI.Configurations
{
    public static class AuthorizationInjection
    {
        public static IServiceCollection AddAuthorizationService(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, SessionBasedAccessHandler>();

            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("Admin", policy =>
                {
                    policy.AddRequirements(new RoleAccessRequirement(Roles.Admin));
                });

                opt.AddPolicy("User", policy =>
                {
                    policy.AddRequirements(new RoleAccessRequirement(Roles.User));
                });

                opt.AddPolicy("AdminOrUser", policy =>
                {
                    policy.AddRequirements(new RoleAccessRequirement(Roles.Admin, Roles.User));
                });

            });

            return services;
        }
    }
}
