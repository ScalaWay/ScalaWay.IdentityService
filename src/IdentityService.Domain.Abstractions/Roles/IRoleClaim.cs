namespace IdentityService.Domain.Abstractions.Roles
{
    /// <summary>
    /// Claim attached to a specific role.
    /// </summary>
    public interface IRoleClaim
    {
        IRole Role { get; set; }

        string ClaimType { get; set; }

        string ClaimValue { get; set; }
    }
}