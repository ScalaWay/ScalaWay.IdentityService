using IdentityService.Domain.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Roles
{
    public class RoleTeamEntityConfiguration : IEntityTypeConfiguration<RoleTeam>
    {
        public void Configure(EntityTypeBuilder<RoleTeam> builder)
        {
            builder.Property(pt => pt.Name)
                   .HasColumnName(nameof(RoleTeam.Name));

            builder.HasData(new RoleTeam { Id = Guid.NewGuid(), Name = "Team Owner" });
        }
    }
}