using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Contracts.Teams
{
    public class TeamOutput
    {
        [NotNull]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
