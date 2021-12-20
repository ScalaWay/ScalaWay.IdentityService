using IdentityService.Domain.Models.Accounts;
using IdentityService.EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Api.Controllers
{
    [ApiController]
    [Route("accounts")]
    public class AccountController : ControllerBase
    {

        private readonly UserManager<Account> userManager;

        public AccountController(
            UserManager<Account> userManager)
        {
            this.userManager = userManager;
        }

        /// <summary>
        /// Get accounts.
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await userManager.GetAllAsync();
            return Ok(users);
        }

        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            return Ok(user);
        }

        /// <summary>
        /// Export to Excel
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        [HttpGet("export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            // todo
            return Ok(null);
        }

    }
}