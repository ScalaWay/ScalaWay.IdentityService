using Lucius.Domain.Abstractions.Entities;

namespace Lucius.Identity.Domain.Abstractions
{
    public interface ITeam : IEntity<Guid>
    {
        string Name { get; set; }

        IEnumerable<IAccount> Members { get; set; }
    }
}