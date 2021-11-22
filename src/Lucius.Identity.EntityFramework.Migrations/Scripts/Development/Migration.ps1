$MigrationName = "DevMigration"

cd ../../

rm ../Lucius.Identity.API/LuciusIdentity.db

dotnet ef database update 0 --startup-project ../Lucius.Identity.API/ --context LuciusIdentityDbContext --configuration Debug
dotnet ef migrations remove --startup-project ../Lucius.Identity.API/ --context LuciusIdentityDbContext --configuration Debug

dotnet clean
dotnet build --no-incremental
dotnet ef migrations add $MigrationName --startup-project ../Lucius.Identity.API/ --context LuciusIdentityDbContext --output-dir ./Migrations/Development --configuration Production

#cd ..
dotnet ef database update --startup-project ../Lucius.Identity.API/ --context LuciusIdentityDbContext --configuration Debug