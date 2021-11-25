using Lucius.Identity.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lucius.Identity.EntityFrameworkCore.Sqlite
{
    public class LuciusIdentityDbContext : IdentityDbContext<AccountEntity, RoleEntity, Guid>
    {
        public LuciusIdentityDbContext()
        { }

        public LuciusIdentityDbContext(DbContextOptions<LuciusIdentityDbContext> options)
             : base(options)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}