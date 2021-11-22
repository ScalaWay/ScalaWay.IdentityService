using Lucius.Identity.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lucius.Identity.EntityFramework.Sqlite.Configurations
{
    public sealed class UserEntityConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            // Change default AspNetUsers table name.
            builder.ToTable("users");

            // Seed mandatory data.
            // https://www.learnentityframeworkcore.com/configuration/fluent-api/hasdata-method
            builder.HasData(
                new UserModel { 
                    Id = Guid.NewGuid(),
                    Email = "admin@luciustack.io"
                }
            );
        }
    }
}