using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.EntityFrameworkCore.Sqlite;

namespace Lucius.Identity.Data
{
    /// <summary>
    /// Abstract repository.
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public sealed class IdentityRepository<TAggregateRoot> : SpecificationRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        private readonly LuciusIdentityDbContext luciusIdentityDbContext;

        public IdentityRepository(LuciusIdentityDbContext dbContext) : base(dbContext)
        {
            luciusIdentityDbContext = dbContext;
        }
    }
}