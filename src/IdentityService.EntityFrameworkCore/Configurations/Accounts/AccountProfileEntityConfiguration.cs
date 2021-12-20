using IdentityService.Domain.Models.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Accounts
{
    public class AccountProfileEntityConfiguration : IEntityTypeConfiguration<AccountProfile>
    {
        public void Configure(EntityTypeBuilder<AccountProfile> builder)
        {
            // Table Splitting technique with AccountEntity
            builder.ToTable("Accounts");

            builder.HasKey(pt => pt.AccountId);
        }
    }
}