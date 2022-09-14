using CarvedRock.OrderProcessor;
using Serilog;

Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.WithMachineName()
            .WriteTo.Console()
            //.WriteTo.File("log.txt",
            //rollingInterval: RollingInterval.Day,
            //rollOnFileSizeLimit: true)
            .CreateLogger();

Log.Information("Serilog enabled {0}", DateTime.Now);

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
