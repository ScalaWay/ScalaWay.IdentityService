using Lucius.Identity.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions.Accounts;
using Lucius.Identity.Domain.Entities.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Accounts
{
    public class AccountRoleEntity : IAccountRole
    {

        public RoleEntity Role { get; set; }

        public AccountEntity Account { get; set; }

        [NotMapped]
        IRole IAccountRole.Role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        [NotMapped]
        IAccount IAccountRole.Account { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
