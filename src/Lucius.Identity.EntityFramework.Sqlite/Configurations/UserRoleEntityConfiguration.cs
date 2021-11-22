using Lucius.Identity.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lucius.Identity.EntityFramework.Sqlite.Configurations
{
    public sealed class UserRoleEntityConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}