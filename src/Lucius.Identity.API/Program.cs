using Lucius.Specification.Abstractions;

string appName = nameof(Lucius.Identity.API);
var configuration = GetConfiguration();

Log.Logger = CreateSerilogLogger(configuration);

try
{
    Log.Information("Configuring web host ({ApplicationContext})...", appName);
    var builder = WebApplication.CreateBuilder(args);

    // Scan every base controller insides assembly and register them in DI.
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
        DataSource = configuration.GetConnectionString("LuciusIdentity"),
        MigrationAssembly = "Lucius.Identity.EntityFrameworkCore.Migrations"
    });

    builder.Services.AddLuciusIdentity<LuciusIdentityDbContext>();

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

    app.UseHttpsRedirection();
    app.UseRouting();


    // UseAuthentication adds Identity authentication middleware to the request pipeline.
    app.UseAuthentication();


    app.UseAuthorization();

    // Configure API routes with defined controllers.
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    Log.Information("Starting application ({ApplicationContext})...", appName);
    app.Run();
}
catch (Exception ex)
{
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