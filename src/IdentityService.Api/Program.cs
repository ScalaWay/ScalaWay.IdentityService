string appName = nameof(IdentityService.Api);
var configuration = GetConfiguration();

Log.Logger = CreateSerilogLogger(configuration);

try
{
    Log.Information("Configuring web host ({ApplicationContext})...", appName);
    var builder = WebApplication.CreateBuilder(args);

    // Scan every base controller insides assembly and register them in DI.
    builder.Services.AddControllers();

    // Register business services.
    builder.Services.AddRequiredServices(configuration);

    builder.Services.AddCustomSwagger();
    builder.Services.AddCustomIdentity<ScalaIdentityDbContext>();

    // Add authentication services.
    builder.Services.AddCustomAuthentication();

    var app = builder.Build();

    if (args.Length == 1 && args[0].ToLower() == "seed")
    {
        Log.Information("Seeding required application data ({ApplicationContext})...", appName);
        await SeedDataAsync(app);
        return 1;
    }


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
    app.MapControllers();

    Log.Information("Starting application ({ApplicationContext})...", appName);
    app.Run();
    return 1;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})!", appName);
    return 0;
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

async Task SeedDataAsync(IHost app)
{
    var scopeFactory = app.Services.GetService<IServiceScopeFactory>();
    if (scopeFactory == null) 
        throw new InvalidOperationException("Unable to retrieve scope factory from DI.");

    using (var scope = scopeFactory.CreateScope())
    {
        var identitySeeder = scope.ServiceProvider.GetService<IdentitySeeder>();
        if (identitySeeder == null) 
            throw new InvalidOperationException("IdentitySeeder not found inside DI.");

        identitySeeder.Reset();
        await identitySeeder.SeedAsync();
    }
}
