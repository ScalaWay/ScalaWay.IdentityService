namespace IdentityService.Domain.Abstractions.Teams
{
    public interface ITeam : IEntity
    {
        string Name { get; set; }

        string? Description { get; set; }
    }
}