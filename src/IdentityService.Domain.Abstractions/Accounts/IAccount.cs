namespace IdentityService.Domain.Abstractions.Accounts
{
    public interface IAccount : IEntity
    {
        IAccountProfile Profile { get; set; }

        string UserName { get; set; }

        string Email { get; set; }
    }
}