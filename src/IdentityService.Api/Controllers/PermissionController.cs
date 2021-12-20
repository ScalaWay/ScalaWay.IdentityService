using Douanier.Permissions.Managers;
using IdentityService.Application.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace IdentityService.Api.Controllers
{
    [ApiController]
    [Authorize(
            AuthenticationSchemes = "Bearer",
            Roles = IdentityHelpers.Roles.Administrator)]
    [Route("permissions")]
    public class PermissionController : ControllerBase
    {
        private readonly PermissionManager permissionManager;
        private readonly ILogger<PermissionController> logger;

        public PermissionController(
            PermissionManager permissionManager,
            ILogger<PermissionController> logger)
        {
            this.permissionManager = permissionManager ?? throw new ArgumentNullException(nameof(permissionManager));
            this.logger = logger;
        }

        [HttpGet()]
        public async Task<ActionResult> GetPermissions()
        {
            return Ok();
        }


    }
}
