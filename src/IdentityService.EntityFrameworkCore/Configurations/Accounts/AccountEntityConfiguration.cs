using IdentityService.Domain.Models.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Accounts
{
    public class AccountEntityConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            // Configure one to one relationship with profile.
            builder.HasOne(pt => pt.Profile)
                    .WithOne(t => t.Account)
                    .HasForeignKey<AccountProfile>(t => t.AccountId);

            // Configure many to many
        }
    }
}