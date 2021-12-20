using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Roles;
using IdentityService.Domain.Models.Teams;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Lucius.Identity.EntityFrameworkCore
{
    public class ScalaIdentityDbContext : IdentityDbContext<Account, Role, Guid, AccountClaim, AccountRole, AccountLogin, RoleClaim, AccountToken>
    {
        public ScalaIdentityDbContext(
            DbContextOptions<ScalaIdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountProfile> AccountProfiles { get; set; }

        public DbSet<AccountRole> AccountRoles { get; set; }

        //public DbSet<TeamMemberEntity> TeamMembers { get; set; }


        //public DbSet<RoleTeamEntity> RoleTeams { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Keep invoking base class of ASP.NET Identity DbContext
            // until full overriding and tests.
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}