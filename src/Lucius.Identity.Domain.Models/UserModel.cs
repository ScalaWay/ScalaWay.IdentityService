using Lucius.Domain.Abstractions;
using Lucius.Identity.Domain.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace Lucius.Identity.Domain.Models
{
    public class UserModel : IdentityUser<Guid>, IAggregateRoot<Guid>, ILuciusUser
    {
    }
}