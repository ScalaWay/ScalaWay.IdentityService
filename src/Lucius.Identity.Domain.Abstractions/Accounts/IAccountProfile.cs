using Lucius.Domain.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Abstractions.Accounts
{
    public interface IAccountProfile : IEntity<Guid>
    {
        IAccount Account { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
