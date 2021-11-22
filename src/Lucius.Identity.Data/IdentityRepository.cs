using Lucius.Data.EFCore;
using Lucius.Domain.Abstractions;
using Lucius.Identity.EntityFramework.Sqlite;

namespace Lucius.Identity.Data
{
    /// <summary>
    /// Abstract repository.
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public sealed class IdentityRepository<TAggregateRoot> : SpecificationRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        private readonly LuciusIdentityDbContext _luciusIdentityDbContext;

        public IdentityRepository(LuciusIdentityDbContext dbContext) : base(dbContext)
        {
            _luciusIdentityDbContext = dbContext;
        }
    }
}