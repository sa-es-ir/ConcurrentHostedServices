using ConcurrentHostedServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<HostedServiceLifecycle>();

//builder.Services.AddHostedService<HostedServiceA>();
//builder.Services.AddHostedService<HostedServiceB>();

//builder.Services.Configure<HostOptions>(x =>
//{
//    x.ServicesStartConcurrently = true;
//});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
