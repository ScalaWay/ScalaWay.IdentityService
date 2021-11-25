using Lucius.Identity.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions.Accounts;
using Lucius.Identity.Domain.Abstractions.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Accounts
{
    /// <summary>
    /// Many to many association for an Account and a Team.
    /// </summary>
    public class AccountTeamEntity : IAccountTeam
    {
        public IAccount Account { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ITeam Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRoleTeam Role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
