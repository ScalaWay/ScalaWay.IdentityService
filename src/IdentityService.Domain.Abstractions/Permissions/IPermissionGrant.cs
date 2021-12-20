namespace IdentityService.Domain.Abstractions.Permissions
{
    /// <summary>
    /// A permission is an action of the application granted to roles and users.
    /// origin.resourceName.actionName
    /// </summary>
    public interface IPermissionGrant : IEntity
    {
        IPermission Permission { get; set; }

        string? Origin { get; set; }

        string ResourceId { get; set; }

        bool IsGranted { get; set; }
    }
}