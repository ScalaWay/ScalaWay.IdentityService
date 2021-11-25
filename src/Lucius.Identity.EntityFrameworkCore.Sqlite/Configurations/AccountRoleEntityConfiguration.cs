using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lucius.Identity.EntityFrameworkCore.Sqlite.Configurations
{
    public sealed class AccountRoleEntityConfiguration : IEntityTypeConfiguration<AccountRoleEntity>
    {
        public void Configure(EntityTypeBuilder<AccountRoleEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}