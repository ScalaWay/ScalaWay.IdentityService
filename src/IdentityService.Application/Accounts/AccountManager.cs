using IdentityService.Domain.Models.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Accounts
{
    public class AccountManager : UserManager<Account>
    {
        public AccountManager(
            IUserStore<Account> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<Account> passwordHasher, 
            IEnumerable<IUserValidator<Account>> userValidators, 
            IEnumerable<IPasswordValidator<Account>> passwordValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<Account>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
