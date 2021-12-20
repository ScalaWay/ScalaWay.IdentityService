using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Roles;
using System.Diagnostics.CodeAnalysis;

namespace IdentityService.Domain.Models.Teams
{
    /// <summary>
    /// Many to many association for an Account and a Team.
    /// </summary>
    public class TeamMember
    {
        public Guid AccountId { get; set; }

        [NotNull]
        public Account? Account { get; set; }

        public Guid TeamId { get; set; }

        [NotNull]
        public Team? Team { get; set; }

        public Guid RoleId { get; set; }

        [NotNull]
        public RoleTeam? Role { get; set; }
    }
}