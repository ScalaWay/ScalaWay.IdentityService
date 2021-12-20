using IdentityService.Domain.Abstractions.Accounts;
using IdentityService.Domain.Abstractions.Roles;

namespace IdentityService.Domain.Abstractions.Teams
{
    public interface ITeamMember
    {
        /// <summary>
        ///
        /// </summary>
        IAccount Account { get; set; }

        /// <summary>
        ///
        /// </summary>
        ITeam Team { get; set; }

        /// <summary>
        /// Role of the member inside a team.
        /// </summary>
        IRoleTeam Role { get; set; }
    }
}