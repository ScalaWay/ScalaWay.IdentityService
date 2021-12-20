using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Contracts.Roles
{
    public class RoleOutput
    {
        [NotNull]
        public string? Name { get; set; }

        public string? Description { get; set; }

    }
}
