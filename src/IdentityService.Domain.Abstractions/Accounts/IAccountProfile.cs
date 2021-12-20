namespace IdentityService.Domain.Abstractions.Accounts
{
    public interface IAccountProfile : IEntity
    {
        IAccount Account { get; set; }

        string? FirstName { get; set; }

        string? LastName { get; set; }
    }
}