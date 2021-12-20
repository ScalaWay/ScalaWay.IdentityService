using IdentityService.Domain.Models.Accounts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.EntityFrameworkCore.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<List<Account>> GetAllAsync(this UserManager<Account> userManager)
        {
            return await userManager.Users.ToListAsync();
        }
    }
}
