using IdentityService.Domain.Abstractions.Roles;

namespace IdentityService.Domain.Abstractions.Accounts
{
    /// <summary>
    /// Represents the link between an user account and a role.
    /// </summary>
    public interface IAccountRole
    {
        IRole Role { get; set; }

        IAccount Account { get; set; }
    }
}