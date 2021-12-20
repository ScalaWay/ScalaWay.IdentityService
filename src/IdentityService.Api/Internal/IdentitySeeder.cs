using Douanier.Permissions.Managers;
using IdentityService.Application.Contracts;
using IdentityService.Domain.Models.Accounts;
using IdentityService.Domain.Models.Roles;
using Lucius.Data.Abstractions.Uow;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using ScalaWay.EntityFrameworkCore.Uow;

namespace IdentityService.Api.Internal
{
    public class IdentitySeeder
    {
        #region Fields
        private readonly ILogger<IdentitySeeder> logger;
        private readonly ScalaIdentityDbContext dbContext;
        private readonly UserManager<Account> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly PermissionManager permissionManager;
        private readonly IUnitOfWork<ScalaIdentityDbContext> unitOfWork;
        #endregion

        #region Constructor
        public IdentitySeeder(
            ILogger<IdentitySeeder> logger,
            ScalaIdentityDbContext dbContext,
            UserManager<Account> userManager,
            RoleManager<Role> roleManager,
            PermissionManager permissionManager,
            IUnitOfWork<ScalaIdentityDbContext> unitOfWork)
        {
            this.logger = logger;
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            this.roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
            this.permissionManager = permissionManager ?? throw new ArgumentNullException(nameof(permissionManager));
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        #endregion

        #region Methods

        /// <summary>
        /// Reset seeding (usefull only for dev and unit tests).
        /// </summary>
        public virtual void Reset()
        {
            // Clean user accounts
            if (dbContext.Accounts.Any())
            {
                dbContext.Accounts.RemoveRange(dbContext.Accounts);
                dbContext.SaveChanges();
            }

            // Clean roles
            if (dbContext.Roles.Any())
            {
                dbContext.Roles.RemoveRange(dbContext.Roles);
                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Seed database with initial data.
        /// </summary>
        /// <returns></returns>
        public virtual async Task SeedAsync()
        {
            using (var transaction = await unitOfWork.BeginTransactionAsync<IDbContextTransaction>())
            {
                try
                {
                    await SeedRoles();
                    await SeedAccounts();

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    logger.LogError("An error occur while seeding ScalaIdentityDbContext : {err}", ex.Message);
                    await transaction.RollbackAsync();
                }
            }
        }
        #endregion

        #region Seed Roles

        /// <summary>
        /// Check if predefined roles can't be added into database.
        /// </summary>
        /// <returns></returns>
        private bool CanSeedRoles()
        {
            return !dbContext.Roles.Any();
        }

        /// <summary>
        /// Seed database with predefined roles.
        /// </summary>
        /// <returns></returns>
        private async Task SeedRoles()
        {
            if (!CanSeedRoles())
            {
                return;
            }

            var createAdminRole = await roleManager.CreateAsync(new Role()
            {
                Name = IdentityHelpers.Roles.Administrator,
                Description = "Administrator role for Account.",
                RoleType = RoleType.Account,
                IsDefault = true,
                IsStatic = true,
            });

            logger.LogInformation("Create admin role. Success state : {0}", createAdminRole.Succeeded);

            var createBasicRole = await roleManager.CreateAsync(new Role()
            {
                Name = IdentityHelpers.Roles.Basic,
                Description = "Basic role for Account.",
                RoleType = RoleType.Account,
                IsDefault = true,
                IsStatic = true,
            });

            logger.LogInformation("Create basic role. Success state : {0}", createBasicRole.Succeeded);

        }
        #endregion

        #region Seed Accounts

        /// <summary>
        /// Check if predefined accounts can't be added into database.
        /// </summary>
        /// <returns></returns>
        private bool CanSeedAccounts()
        {
            return !dbContext.Accounts.Any();
        }

        /// <summary>
        /// Seed database with predefined accounts.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private async Task SeedAccounts()
        {
            if (!CanSeedAccounts())
            {
                return;
            }

            var createAdminAccount = await userManager.CreateAsync(new Account()
            {
                UserName = "Admin",
                Email = "admin@scalaway.io"
            }, "demopassword");
            logger.LogInformation("Create admin account. Success state : {0}", createAdminAccount.Succeeded);

            //var adminRole = await roleManager.FindByNameAsync(IdentityHelpers.Roles.Administrator);
            //if (adminRole == null)
            //    throw new InvalidOperationException();

            //await userManager.AddToRoleAsync(await userManager.FindByNameAsync("Admin"), adminRole.Name);


            //await dbContext.AccountPermissions.AddAsync(new AccountPermissionGrantEntity()
            //{
            //    AccountId = Guid.Parse("eed58d81-614f-481a-bc02-cc4294dc0639"),
            //    PermissionId = Guid.Parse("c4ae5b90-77e3-4d63-bb12-5926c895773b"),
            //    ResourceId = "*",
            //    IsGranted = true
            //});

            //await dbContext.SaveChangesAsync();

            var demoAccount = new Account(){
                UserName = "Demo",
                Email = "demo@scalaway.io"
            };

            var createUserAccount = await userManager.CreateAsync(demoAccount, "demopassword");
            logger.LogInformation("Create user account. Success state : {0}", createUserAccount.Succeeded);

            var basicRole = await roleManager.FindByNameAsync(IdentityHelpers.Roles.Basic);
            if (basicRole == null)
                throw new InvalidOperationException();

            await userManager.AddToRoleAsync(demoAccount, basicRole.Name);
        }
        #endregion
    }
}