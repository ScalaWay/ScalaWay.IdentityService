using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
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
    }
}
