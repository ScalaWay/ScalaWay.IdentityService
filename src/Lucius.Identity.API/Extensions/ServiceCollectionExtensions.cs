using Lucius.Identity.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lucius.Identity.API.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static IServiceCollection AddCustomDbContext(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddLuciusIdentity<TDbContext>(this IServiceCollection services)
            where TDbContext : LuciusIdentityDbContext
        {
            services.AddIdentity<AccountEntity, RoleEntity>()
                .AddEntityFrameworkStores<TDbContext>();

            return services;
        }



    }
}