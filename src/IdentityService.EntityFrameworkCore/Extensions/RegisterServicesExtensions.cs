using IdentityService.Domain.Models.Accounts;
using IdentityService.EntityFrameworkCore.Stores;
using Lucius.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScalaWay.EntityFrameworkCore.Extensions;

namespace IdentityService.EntityFrameworkCore.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static IServiceCollection RegisterIdentityDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserStore<Account>, AccountStore>();

            services.AddDbContext<ScalaIdentityDbContext>(builder => builder.UseSqlite(configuration.GetConnectionString("Identity"),
                sql => sql.MigrationsAssembly(configuration.GetValue<string>("MigrationAssembly"))));
            
            services.AddUnitOfWork<ScalaIdentityDbContext>();
            
            return services;
        }

        public static IServiceCollection RegisterIdentityDbContext(this IServiceCollection services, string database)
        {
            services.AddScoped<IUserStore<Account>, AccountStore>();

            services.AddDbContext<ScalaIdentityDbContext>(builder => builder.UseSqlite(database));
            
            services.AddUnitOfWork<ScalaIdentityDbContext>();
            
            return services;
        }

        public static IServiceCollection RegisterDouanierDbContext(
            this IServiceCollection services,
            IConfiguration configuration,
            Type permissionProvider)
        {
            services
                .AddDouanier(options =>
                {
                    options.Permission.PermissionProviders.Add(permissionProvider);
                })
                .AddDouanierContext<IdentityDouanierDbContext>(options =>
                {
                    options.ConfigureDbContext = builder => builder.UseSqlite(configuration.GetConnectionString("Douanier"),
                        sql => sql.MigrationsAssembly(configuration.GetValue<string>("MigrationAssembly")));
                });
            services.AddUnitOfWork<IdentityDouanierDbContext>();

            return services;
        }
    }
}