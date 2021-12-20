namespace IdentityService.Domain.Models.Roles
{
    /// <summary>
    /// Defines which role can be attributed to a Team.
    /// </summary>
    public class RoleTeam : Role
    {
        public RoleTeam() : base()
        {
        }

        public override RoleType RoleType { get; set; }
    }
}