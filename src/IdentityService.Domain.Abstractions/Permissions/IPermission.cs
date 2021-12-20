namespace IdentityService.Domain.Abstractions.Permissions
{
    public interface IPermission : IEntity
    {
        string Name { get; set; }

        string? DisplayName { get; set; }

        string? Description { get; set; }

        string ResourceName { get; set; }

        string ActionName { get; set; }

        string? Constraint { get; set; }

        bool IsStatic { get; set; }

        IPermissionGroup? PermissionGroup { get; set; }
    }
}