
using ConcurrentHostedServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<HostedServiceA>();
builder.Services.AddHostedService<HostedServiceB>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
