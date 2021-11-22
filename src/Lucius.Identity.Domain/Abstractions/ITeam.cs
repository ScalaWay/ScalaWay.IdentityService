using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions
{
    public interface ITeam
    {
        string Name { get; set; }

        IEnumerable<ILuciusUser> Members { get; set; }
    }
}
