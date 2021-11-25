using Lucius.Identity.Domain.Abstractions;

namespace Lucius.Identity.Domain.Entities.Implementations
{
    public class Account : IAccount
    {
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRole Role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<ITeam> Teams { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<IPermission> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}