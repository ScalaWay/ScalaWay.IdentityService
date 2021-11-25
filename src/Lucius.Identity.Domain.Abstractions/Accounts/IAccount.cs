using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions.Accounts;

namespace Lucius.Identity.Domain.Abstractions
{
    public interface IAccount : IEntity<Guid>
    {
        IRole Role { get; set; }

        IAccountProfile Profile { get; set; }

        IEnumerable<ITeam> Teams { get; set; }

        IEnumerable<IPermissionGrant> Permissions { get; set; }

        string UserName { get; set; }

        string Email { get; set; }
    }
}