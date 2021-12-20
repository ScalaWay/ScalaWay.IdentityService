using IdentityService.Domain.Models.Accounts;
using ScalaWay.Domain.Abstractions.Entities;
using System.Diagnostics.CodeAnalysis;

namespace IdentityService.Domain.Models.Teams
{
    public class Team : IAggregateRoot<Guid>
    {
        public Team()
        {
            this.Members = new List<Account>();
            this.TeamMembers = new List<TeamMember>();
        }

        public Guid Id { get; set; }

        [NotNull]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public IEnumerable<Account> Members { get; set; }

        // Navigation property used for many-to-many relationship
        // with accounts.
        public IEnumerable<TeamMember> TeamMembers { get; set; }
    }
}