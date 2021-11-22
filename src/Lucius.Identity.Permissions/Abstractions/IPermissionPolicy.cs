using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Permissions.Abstractions
{
    public interface IPermissionPolicy
    {
        string Name { get; set; }

        bool IsValid { get; }
    }
}
