using Microsoft.Extensions.DependencyInjection;

namespace Lucius.Identity.Permissions.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPermissionPolicies(this IServiceCollection services, string configSection = "permissions")
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (string.IsNullOrWhiteSpace(configSection))
                throw new ArgumentNullException(nameof(configSection));

            //services.AddSingleton<IAuthorizationPolicyProvider>(sp =>
            //{
            //    var config = sp.GetRequiredService<IConfiguration>();

            //    var permissions = new Dictionary<string, IDictionary<string, string[]>[]>();

            //    //config.GetSection(configSection).Bind(permissions);

            //    return new PermissionPolicyProvider(PermissionPolicy.FromDictionary(permissions));
            //});

            //services.AddSingleton<IPermissionPolicyProvider>(sp =>
            //{
            //    return (IPermissionPolicyProvider)sp.GetRequiredService<IAuthorizationPolicyProvider>();
            //});
        }
    }
}