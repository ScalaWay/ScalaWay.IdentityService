using Lucius.Identity.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Permissions.Domain
{
    internal class PermissionPolicy : IPermissionPolicy
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid => throw new NotImplementedException();

    }
}
