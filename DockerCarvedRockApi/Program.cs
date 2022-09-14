using DockerCarvedRockApi.Domain;
using DockerCarvedRockApi.Interfaces;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IQuickOrderLogic, QuickOrderLogic>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.WithMachineName()
            .WriteTo.Console()
            //.WriteTo.File("log.txt",
            //rollingInterval: RollingInterval.Day,
            //rollOnFileSizeLimit: true)
            .CreateLogger();

Log.Information("Serilog enabled {0}", DateTime.Now);

//Log.CloseAndFlush();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
