using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Teams
{
    public class TeamEntity : IAggregateRoot<Guid>, ITeam
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<IAccount> Members { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
