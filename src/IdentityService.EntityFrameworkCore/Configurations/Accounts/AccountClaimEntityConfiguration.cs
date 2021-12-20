using IdentityService.Domain.Models.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Accounts
{
    public class AccountClaimEntityConfiguration : IEntityTypeConfiguration<AccountClaim>
    {
        public void Configure(EntityTypeBuilder<AccountClaim> builder)
        {
            builder.ToTable("AccountClaims");
        }
    }
}