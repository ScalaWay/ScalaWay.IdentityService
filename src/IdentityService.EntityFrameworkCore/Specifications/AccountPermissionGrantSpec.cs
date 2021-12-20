//using IdentityService.Domain.Models.Accounts;
//using Lucius.Specification;
//using Lucius.Specification.Abstractions;
//using Lucius.Specification.Builder;

//namespace IdentityService.EntityFrameworkCore.Specifications
//{
//    public class AccountPermissionGrantSpec : Specification<AccountPermissionGrantEntity>, ISingleResultSpecification
//    {
//        public AccountPermissionGrantSpec(Guid accountId, string permissionName, string resourceId)
//        {
//            Query.Where(x => x.AccountId == accountId &&
//                x.Permission.Name.Equals(permissionName) &&
//                x.ResourceId.Equals(resourceId));
//        }
//    }
//}