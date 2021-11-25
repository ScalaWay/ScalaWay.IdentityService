using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Permissions
{
    public class PermissionEntity : IAggregateRoot<Guid>, IPermissionGrant
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DisplayName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPermissionGroup PermissionGroup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
