using IdentityService.Api.Internal;
using IdentityService.Application.Authorization;
using IdentityService.Application.Extensions;
using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Roles;
using IdentityService.EntityFrameworkCore.Extensions;
using IdentityService.EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using ScalaWay.Domain.Abstractions.Repositories;

namespace IdentityService.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterIdentityDbContext(configuration);
            services.RegisterDouanierDbContext(configuration, typeof(IdentityPermissionProvider));
            services.RegisterApplicationServices();

            services.AddScoped(typeof(IReadableSpecificationRepository<>), typeof(IdentityRepository<>));

            services.AddTransient<IdentitySeeder>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            return services;
        }

        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.Audience = "workspace";
                    options.Authority = "https://localhost:5001";
                    options.TokenValidationParameters.ValidateAudience = false;

                    // it's recommended to check the type header to avoid "JWT confusion" attacks
                    options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
                });
            return services;
        }

        public static IServiceCollection AddCustomIdentity<TDbContext>(this IServiceCollection services)
            where TDbContext : ScalaIdentityDbContext
        {
            services
                .AddIdentity<Account, Role>(options =>
                {
                    options.User.RequireUniqueEmail = true;

                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 0;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;

                    // SignIn Options
                    options.SignIn.RequireConfirmedEmail = false;
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedPhoneNumber = false;

                    //options.Tokens.
                })
                .AddEntityFrameworkStores<TDbContext>();

            return services;
        }
    }
}