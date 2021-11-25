using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Accounts
{
    public class AccountPermissionEntity : IAggregateRoot<Guid>, IAccountPermission
    {
        public Guid AccountId { get; set; }

        public IAccount Account { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PermissionId { get; set; }

        public IPermission Permission { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
