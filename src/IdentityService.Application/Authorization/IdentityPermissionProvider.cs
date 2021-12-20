using Douanier.Abstractions.Permissions;
using Douanier.Abstractions.Permissions.Entities;
using Douanier.Permissions;
using IdentityService.Application.Contracts.Authorization;

namespace IdentityService.Application.Authorization
{
    public class IdentityPermissionProvider : PermissionProvider
    {
        public override void SetPermissions(IPermissionContext<PermissionGroup, Permission> permissionContext)
        {
            var accountPermissionGroup = permissionContext.CreatePermissionGroup("Accounts");

            permissionContext.CreatePermission(ServicePermissions.Accounts.All, accountPermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Accounts.Read, accountPermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Accounts.Create, accountPermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Accounts.Update, accountPermissionGroup);
            permissionContext.CreatePermission(ServicePermissions.Accounts.Delete, accountPermissionGroup);
        }
    }
}