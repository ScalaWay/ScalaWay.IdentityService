using IdentityService.Application.Contracts.Authentication.Requests;
using IdentityService.Domain.Models.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Api.Controllers
{
    public class AuthenticationController : ControllerBase
    {

        #region Fields
        private readonly SignInManager<Account> signInManager;
        private readonly UserManager<Account> userManager;
        #endregion

        #region Constructor
        public AuthenticationController(SignInManager<Account> signInManager)
        {
            this.signInManager = signInManager;
        }
        #endregion

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginAsync()
        {
            // todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register a User
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Status 200 OK</returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            // todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// Forgot Password
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Status 200 OK</returns>
        [HttpPost("forgot-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            // todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Status 200 OK</returns>
        [HttpPost("reset-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordRequest request)
        {
            // todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// Confirm Email
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="code"></param>
        /// <returns>Status 200 OK</returns>
        [HttpGet("confirm-email")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            // todo
            throw new NotImplementedException();
        }
    }
}
