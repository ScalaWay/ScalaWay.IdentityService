$ConfigurationMode = "Debug"

$IdentityMigrationName = "Identity"
$IdentityDbContext = "ScalaIdentityDbContext"

$DouanierMigrationName = "Douanier"
$DouanierDbContext = "IdentityDouanierDbContext"

# Move to solution root directory
cd ../../

# Remove existing databases
rm ../IdentityService.Api/*.db

# Remove any existing migrations for ScalaIdentityDbContext
dotnet ef migrations remove --startup-project ../IdentityService.Api/ --context $IdentityDbContext --configuration $ConfigurationMode

# Remove any existing migrations for Douanier DbContext
dotnet ef migrations remove --startup-project ../IdentityService.Api/ --context $DouanierDbContext --configuration $ConfigurationMode

# Clean & rebuild solution
dotnet clean
dotnet build --no-incremental

# Create initial migration script for Identity DbContext
dotnet ef migrations add $IdentityMigrationName --startup-project ../IdentityService.Api/ --context $IdentityDbContext --output-dir ./Identity/Development --configuration $ConfigurationMode

# Create initial migration script for Douanier DbContext
dotnet ef migrations add $DouanierMigrationName --startup-project ../IdentityService.Api/ --context $DouanierDbContext --output-dir ./Douanier/Development --configuration $ConfigurationMode

# Apply migrations (this will create a clean database)
dotnet ef database update --startup-project ../IdentityService.Api/ --context $IdentityDbContext --configuration $ConfigurationMode
dotnet ef database update --startup-project ../IdentityService.Api/ --context $DouanierDbContext --configuration $ConfigurationMode