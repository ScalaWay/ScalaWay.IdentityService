cd ../..
dotnet ef migrations add InitialMigration --context LuciusIdentityDbContext --startup-project ../Lucius.Identity.API/ --output-dir ../../Migrations --configuration Debug
dotnet ef database update --context LuciusIdentityDbContext --startup-project ../Lucius.Identity.API/ --configuration Debug