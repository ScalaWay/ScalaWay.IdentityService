using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions.Permissions
{
    public interface IPermissionGroup
    {
        string Name { get; set; }

        IEnumerable<IPermissionGrant> Permissions { get; set; }

        IPermissionGrant AddPermission(IPermissionGrant permission);
    }
}
