using Lucius.Identity.Domain.Entities.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lucius.Identity.EntityFrameworkCore.Sqlite.Configurations
{
    public sealed class AccountEntityConfiguration : IEntityTypeConfiguration<AccountEntity>
    {
        public void Configure(EntityTypeBuilder<AccountEntity> builder)
        {
            // Change default AspNetUsers table name.
            builder.ToTable("users");

            // Seed mandatory data.
            // https://www.learnentityframeworkcore.com/configuration/fluent-api/hasdata-method
            builder.HasData(
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@luciustack.io"
                }
            );
        }
    }
}