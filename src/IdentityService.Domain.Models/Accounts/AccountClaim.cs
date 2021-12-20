using Microsoft.AspNetCore.Identity;

namespace IdentityService.Domain.Models.Accounts
{
    /// <summary>
    ///
    /// </summary>
    public class AccountClaim : IdentityUserClaim<Guid>
    {
        public AccountClaim() : base()
        {
        }
    }
}