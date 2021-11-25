using Lucius.Domain.Abstractions.Entities;

namespace Lucius.Identity.Domain.Abstractions
{
    /// <summary>
    /// Represents a role in an application. A role is used to group permissions.
    /// </summary>
    /// <remarks>
    /// Application should use permissions to check if user is granted to perform an operation.
    /// Checking 'if a user has a role' is not possible until the role is static (<see cref="AbpRoleBase.IsStatic"/>).
    /// Static roles can be used in the code and can not be deleted by users.
    /// Non-static (dynamic) roles can be added/removed by users and we can not know their name while coding.
    /// A user can have multiple roles. Thus, user will have all permissions of all assigned roles.
    /// </remarks>
    public interface IRole : IEntity<int>
    {

        /// <summary>
        /// Is this role assigned to new users by default?
        /// </summary>
        bool IsDefault { get; set; }

        /// <summary>
        /// Is this role static? (setup during pre-build, and can not be deleted).
        /// </summary>
        bool IsStatic { get; set; }

        string Name { get; set; }

        string Description { get; set; }

    }
}