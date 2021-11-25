using Lucius.Domain.Abstractions.Entities;
using Lucius.EntityFrameworkCore.Repositories;
using Lucius.Identity.EntityFrameworkCore.Sqlite;

namespace Lucius.Identity.Data
{
    /// <summary>
    /// Generic repository implementation which can be attached with any aggregate root.
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public sealed class IdentityRepository<TAggregateRoot> : EntityFrameworkSpecRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        private readonly LuciusIdentityDbContext luciusIdentityDbContext;

        public IdentityRepository(LuciusIdentityDbContext dbContext) : base(dbContext)
        {
            luciusIdentityDbContext = dbContext;
        }
    }
}