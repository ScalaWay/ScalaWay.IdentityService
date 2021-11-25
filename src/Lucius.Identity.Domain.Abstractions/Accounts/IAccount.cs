using Lucius.Domain.Abstractions.Entities;

namespace Lucius.Identity.Domain.Abstractions
{
    public interface IAccount : IEntity<Guid>
    {
        IRole Role { get; set; }

        IEnumerable<ITeam> Teams { get; set; }

        IEnumerable<IPermission> Permissions { get; set; }

        string UserName { get; set; }

        string Email { get; set; }
    }
}