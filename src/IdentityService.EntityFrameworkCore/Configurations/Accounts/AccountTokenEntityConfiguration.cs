using IdentityService.Domain.Models.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Accounts
{
    public class AccountTokenEntityConfiguration : IEntityTypeConfiguration<AccountToken>
    {
        public void Configure(EntityTypeBuilder<AccountToken> builder)
        {
            builder.ToTable("AccountTokens");
        }
    }
}