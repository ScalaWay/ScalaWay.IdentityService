using Lucius.Domain.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccountPermission : IEntity<Guid>
    {
        IAccount Account { get; set; }

        IPermission Permission { get; set; }

    }
}
