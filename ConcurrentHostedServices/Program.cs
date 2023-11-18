using ConcurrentHostedServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<HostedServiceA>();
builder.Services.AddHostedService<HostedServiceB>();

//builder.Services.Configure<HostOptions>(x =>
//{
//    x.ServicesStartConcurrently = true;
//    x.ServicesStopConcurrently = true;
//});

//builder.Services.AddHostedService<HostedServiceLifecycle>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
