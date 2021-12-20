using IdentityService.Application.Contracts.Roles.Requests;
using IdentityService.Domain.Models.Roles;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Api.Controllers
{
    public class RoleController : ControllerBase
    {

        #region Fields

        private readonly RoleManager<Role> roleManager;

        #endregion

        #region Constructor

        public RoleController(
            RoleManager<Role> roleManager)
        {
            this.roleManager = roleManager;
        }

        #endregion

        /// <summary>
        /// Get Role By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [HttpGet("roles/{id}")]
        public async Task<IActionResult> GetAllRolesAsync(Guid id)
        {
            // todo
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update a role.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Status 200 OK</returns>
        [HttpPut("roles/{id}")]
        public async Task<IActionResult> UpdateRoleAsync(UpdateRoleRequest request)
        {
            // todo
            throw new NotImplementedException();
        }
    }
}
