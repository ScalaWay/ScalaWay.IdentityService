using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions.Accounts
{
    /// <summary>
    /// Represents the link between an user account and a role.
    /// </summary>
    public interface IAccountRole
    {
        IRole Role { get; set; }
        IAccount Account { get; set; }
    }
}
