//namespace IdentityService.Api.Attributes
//{
//    public class PermissionRequirementFilter : IAuthorizationFilter
//    {
//        private readonly string permission;

//        public PermissionRequirementFilter(string permission)
//        {
//            this.permission = permission;
//        }

//        public async void OnAuthorization(AuthorizationFilterContext context)
//        {
//            var user = context.HttpContext.User;
//            if (user == null || user.Identity == null || !user.Identity.IsAuthenticated)
//            {
//                context.Result = new UnauthorizedResult();
//                return;
//            }

//            var permissionService = context.HttpContext.RequestServices.GetService<PermissionService>();
//            if (permissionService == null)
//            {
//                context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
//                return;
//            }

//            var isAuthorized = await permissionService.HasAuthorization("EED58D81-614F-481A-BC02-CC4294DC0639", this.permission, "*");
//            if (!isAuthorized)
//            {
//                context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
//            }
//        }
//    }
//}