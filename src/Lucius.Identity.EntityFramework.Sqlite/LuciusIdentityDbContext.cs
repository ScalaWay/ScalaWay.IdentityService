using Lucius.Data.Abstractions;
using Lucius.Identity.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lucius.Identity.EntityFramework.Sqlite
{
    public class LuciusIdentityDbContext : IdentityDbContext<UserModel, RoleModel, Guid>, ILuciusDbContext
    {
        public LuciusIdentityDbContext() { }

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