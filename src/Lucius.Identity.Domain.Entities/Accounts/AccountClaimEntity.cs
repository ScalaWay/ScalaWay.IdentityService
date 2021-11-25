using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountClaimEntity : IdentityUserClaim<Guid>, IAggregateRoot<Guid>, IAccountClaim
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
