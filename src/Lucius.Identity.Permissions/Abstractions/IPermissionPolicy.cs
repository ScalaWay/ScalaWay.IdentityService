namespace Lucius.Identity.Permissions.Abstractions
{
    public interface IPermissionPolicy
    {
        string Name { get; set; }

        bool IsValid { get; }
    }
}