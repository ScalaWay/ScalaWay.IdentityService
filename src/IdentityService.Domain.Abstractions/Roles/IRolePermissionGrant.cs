using IdentityService.Domain.Abstractions.Permissions;

namespace IdentityService.Domain.Abstractions.Roles
{
    public interface IRolePermissionGrant : IPermissionGrant
    {
        IRole Role { get; set; }
    }
}