using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Roles;
using Lucius.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityService.EntityFrameworkCore.Stores
{
    public class AccountStore : UserStore<Account, Role, ScalaIdentityDbContext, Guid, AccountClaim, AccountRole, AccountLogin, AccountToken, RoleClaim>
    {
        public AccountStore(
            ScalaIdentityDbContext context, 
            IdentityErrorDescriber describer = null!) : base(context, describer)
        {
            AutoSaveChanges = true;
        }
    }
}
