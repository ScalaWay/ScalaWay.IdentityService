using IdentityService.Domain.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Roles
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Define table name.
            builder.ToTable("Roles");

            builder
                .HasDiscriminator(pt => pt.RoleType)
                .HasValue<Role>(RoleType.Account)
                .HasValue<RoleTeam>(RoleType.Team);

            builder
                .Property(pt => pt.RoleType)
                .HasConversion<string>();
        }
    }
}