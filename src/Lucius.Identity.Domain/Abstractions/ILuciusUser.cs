using Lucius.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions
{
    public interface ILuciusUser : IEntity<Guid>
    {
        string UserName { get; set; }

        string Email { get; set; }
    }
}
