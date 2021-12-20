using ScalaWay.Domain.Abstractions.Entities;
using System.Diagnostics.CodeAnalysis;

namespace IdentityService.Domain.Models.Accounts
{
    /// <summary>
    /// Represents a one-to-one relationship between an Account and Profile.
    /// </summary>
    public class AccountProfile : IAggregateRoot
    {
        public Guid AccountId { get; set; }

        public string? FirstName { get; set; } = null;

        public string? LastName { get; set; } = null;

        [NotNull]
        public Account? Account { get; set; }
    }
}