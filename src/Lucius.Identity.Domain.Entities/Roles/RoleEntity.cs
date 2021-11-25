using Lucius.Domain.Abstractions.Entities;
using Lucius.Identity.Domain.Abstractions;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucius.Identity.Domain.Entities.Roles
{
    public class RoleEntity : IdentityRole<int>, IAggregateRoot<int>, IRole
    {

        public RoleEntity() : base() { }

        public bool IsDefault { get; set; }
        public bool IsStatic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}