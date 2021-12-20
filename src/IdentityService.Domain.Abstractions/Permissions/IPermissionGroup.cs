namespace IdentityService.Domain.Abstractions.Permissions
{
    public interface IPermissionGroup
    {
        string Name { get; set; }

        IEnumerable<IPermission> Permissions { get; set; }

        IPermission AddPermission(IPermission permission);
    }
}