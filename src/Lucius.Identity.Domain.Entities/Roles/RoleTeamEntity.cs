using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucius.Identity.Domain.Entities.Roles
{
    /// <summary>
    /// Defines which role can be attributed to a Team.
    /// </summary>
    public class RoleTeamEntity : IAggregateRoot<Guid>, IRoleTeam
    {
        public RoleTeamEntity()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDefault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsStatic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
