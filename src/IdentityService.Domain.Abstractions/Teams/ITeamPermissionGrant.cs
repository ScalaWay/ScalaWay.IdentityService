using IdentityService.Domain.Abstractions.Permissions;

namespace IdentityService.Domain.Abstractions.Teams
{
    public interface ITeamPermissionGrant : IPermissionGrant
    {
        ITeam Team { get; set; }
    }
}