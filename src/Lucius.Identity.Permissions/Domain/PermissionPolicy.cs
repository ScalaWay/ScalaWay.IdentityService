using Lucius.Identity.Permissions.Abstractions;

namespace Lucius.Identity.Permissions.Domain
{
    internal class PermissionPolicy : IPermissionPolicy
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid => throw new NotImplementedException();
    }
}