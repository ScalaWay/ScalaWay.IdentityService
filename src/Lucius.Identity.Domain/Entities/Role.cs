using Lucius.Identity.Domain.Abstractions;

namespace Lucius.Identity.Domain.Entities.Implementations
{
    public class Role : IRole
    {
        public bool IsDefault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<IAccount> Accounts => throw new NotImplementedException();

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsStatic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}