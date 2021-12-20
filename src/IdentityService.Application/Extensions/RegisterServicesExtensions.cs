using IdentityService.Application.Accounts;
using IdentityService.Domain.Models.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
