using Lucius.Identity.Domain.Abstractions.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions.Accounts
{
    /// <summary>
    /// Represents membership of an Account to a Team.
    /// </summary>
    public interface IAccountTeam
    {
        /// <summary>
        /// 
        /// </summary>
        IAccount Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ITeam Team { get; set; }

        /// <summary>
        /// Role of the member inside a team.
        /// </summary>
        IRoleTeam Role { get; set; }
    }
}
