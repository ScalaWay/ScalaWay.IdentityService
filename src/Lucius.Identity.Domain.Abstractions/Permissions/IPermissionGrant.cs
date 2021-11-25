using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions
{
    /// <summary>
    /// A permission is an action of the application granted to roles and users.
    /// </summary>
    public interface IPermissionGrant : IEntity<Guid>
    {
        string Name { get; set; }

        string DisplayName { get; set; }

        IPermissionGroup PermissionGroup { get; set; }
    }
}
