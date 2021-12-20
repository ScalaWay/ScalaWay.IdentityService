using IdentityService.Domain.Models.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.EntityFrameworkCore.Configurations.Accounts
{
    public class AccountLoginEntityConfiguration : IEntityTypeConfiguration<AccountLogin>
    {
        public void Configure(EntityTypeBuilder<AccountLogin> builder)
        {
            builder.ToTable("AccountLogins");
        }
    }
}