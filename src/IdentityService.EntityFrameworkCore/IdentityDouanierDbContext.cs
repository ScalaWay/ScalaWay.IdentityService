using Douanier.EntityFrameworkCore;
using Douanier.EntityFrameworkCore.Options;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.EntityFrameworkCore
{
    public class IdentityDouanierDbContext : DouanierDbContext
    {
        public IdentityDouanierDbContext(
            DbContextOptions<IdentityDouanierDbContext> options,
            DouanierDbContextOptions authorizationContextOptions) : base(options, authorizationContextOptions)
        {
        }
    }
}