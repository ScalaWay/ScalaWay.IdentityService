using Lucius.Identity.EntityFrameworkCore;
using ScalaWay.Domain.Abstractions.Entities;
using ScalaWay.EntityFrameworkCore.Repositories;

namespace IdentityService.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Generic repository implementation which can be attached with any aggregate root.
    /// </summary>
    /// <typeparam name="TAggregateRoot"></typeparam>
    public sealed class IdentityRepository<TAggregateRoot> : EntityFrameworkSpecRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        private readonly ScalaIdentityDbContext identityDbContext;

        public IdentityRepository(ScalaIdentityDbContext dbContext) : base(dbContext)
        {
            identityDbContext = dbContext;
        }
    }
}