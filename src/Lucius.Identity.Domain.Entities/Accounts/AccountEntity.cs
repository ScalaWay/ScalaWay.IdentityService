using Lucius.Domain.Abstractions;
using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions.Accounts;
using Lucius.Identity.Domain.Entities;
using Lucius.Identity.Domain.Entities.Roles;
using Lucius.Identity.Domain.Entities.Teams;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucius.Identity.Domain.Entities.Accounts
{
    public class AccountEntity : IdentityUser<Guid>, IAggregateRoot<Guid>, IAccount
    {

        public RoleEntity Role { get; set; }

        public IEnumerable<TeamEntity> Teams { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      
        public IEnumerable<IPermissionGrant> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAccountProfile Profile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        [NotMapped]
        IRole IAccount.Role { get => Role; set => Role = value as RoleEntity; }

        [NotMapped]
        IEnumerable<ITeam> IAccount.Teams { get => Teams; set => Teams = value as IEnumerable<TeamEntity>; }

    }
}