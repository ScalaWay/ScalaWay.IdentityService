using Lucius.Identity.Domain.Abstractions;

namespace Lucius.Identity.Domain.Entities.Implementations
{
    public class Role : IRole
    {

        public Role()
        {

        }

        public bool IsDefault { get; set; }

        public ICollection<IAccount> Accounts { get; set; }

        public Guid Id { get; set; }
        public bool IsStatic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}