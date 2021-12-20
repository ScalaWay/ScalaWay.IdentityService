using Microsoft.AspNetCore.Identity;
using ScalaWay.Domain.Abstractions.Entities;

namespace IdentityService.Domain.Models.Roles
{
    public class Role : IdentityRole<Guid>, IAggregateRoot<Guid>
    {
        public Role() : base()
        {
        }

        public bool IsDefault { get; set; } = false;

        public bool IsStatic { get; set; } = false;

        public string? Description { get; set; }

        public virtual RoleType RoleType { get; set; }
    }
}