using IdentityService.Domain.Models.Roles;
using IdentityService.Domain.Models.Teams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Teams
{
    public class TeamMemberEntityConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.ToTable("TeamMembers");

            builder
                .HasOne(pt => pt.Role)
                .WithMany()
                .HasForeignKey(pt => pt.RoleId);
        }
    }
}