using Lucius.Data.EFCore.Extensions;
using Lucius.Data.EFCore.Settings;
using Lucius.Identity.Data;
using Lucius.Identity.EntityFramework.Sqlite;
using Lucius.Specification.Abstractions;

var appName = nameof(Lucius.Identity.API);
var configuration = GetConfiguration();

Log.Logger = CreateSerilogLogger(configuration);

try
{
    Log.Information("Configuring web host ({ApplicationContext})...", appName);
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();

    // Register swagger generator.
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    });

    // Register database provider.
    builder.Services.AddSqliteDbContext<LuciusIdentityDbContext>(new SQLiteDbSettings()
    {
        DataSource = "Data Source=LuciusIdentity.db;",
        MigrationAssembly = "Lucius.Identity.EntityFramework.Migrations"
    });

    // Register business services.
    builder.Services.AddScoped(typeof(ISpecificationRepository<>), typeof(IdentityRepository<>));
    
    var app = builder.Build();

    Log.Information("Configuring HTTP request pipeline ({ApplicationContext})...", appName);
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();

        // https://github.com/domaindrivendev/Swashbuckle.AspNetCore
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseRouting();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    // Configure API routes with defined controllers.
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    Log.Information("Starting application ({ApplicationContext})...", appName);
    app.Run();
} catch (Exception ex) {
    Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})!", appName);
}

/// <summary>
/// CreateSerilogLogger
/// </summary>
Serilog.ILogger CreateSerilogLogger(IConfiguration configuration)
{
    return new LoggerConfiguration()
        .MinimumLevel.Verbose()
        .Enrich.WithProperty("ApplicationContext", appName)
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();
}

/// <summary>
/// GetConfiguration
/// </summary>
IConfiguration GetConfiguration()
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables();

    return builder.Build();
}
