using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Teams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Teams
{
    public class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            // Define table name.
            builder.ToTable("Teams");

            // Configure many to many relationship with accounts.
            builder.HasMany(p => p.Members)
                .WithMany(p => p.Teams)
                .UsingEntity<TeamMember>(
                    j => j
                         .HasOne(p => p.Account)
                         .WithMany(t => t.TeamMembers)
                         .HasForeignKey(pt => pt.AccountId),
                    j => j
                         .HasOne(p => p.Team)
                         .WithMany(t => t.TeamMembers)
                         .HasForeignKey(pt => pt.TeamId),
                    j =>
                    {
                        j.HasKey(t => new { t.TeamId, t.AccountId });
                    });
        }
    }
}