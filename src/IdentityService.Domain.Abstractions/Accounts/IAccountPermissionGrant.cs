using IdentityService.Domain.Abstractions.Permissions;

namespace IdentityService.Domain.Abstractions.Accounts
{
    /// <summary>
    ///
    /// </summary>
    public interface IAccountPermissionGrant : IPermissionGrant
    {
        IAccount Account { get; set; }
    }
}