using IdentityService.Domain.Models.Teams;
using Microsoft.AspNetCore.Identity;
using ScalaWay.Domain.Abstractions.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IdentityService.Domain.Models.Accounts
{
    public class Account : IdentityUser<Guid>, IAggregateRoot<Guid>
    {
        public Account() : base()
        {
            this.Teams = new Collection<Team>();
            this.TeamMembers = new Collection<TeamMember>();
        }

        [Required]
        [NotNull]
        public AccountProfile? Profile { get; set; }

        public IEnumerable<Team> Teams { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }
    }
}