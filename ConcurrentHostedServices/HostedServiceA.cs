namespace ConcurrentHostedServices;

public class HostedServiceA : IHostedService
{
    private readonly ILogger<HostedServiceA> _logger;

    public HostedServiceA(ILogger<HostedServiceA> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("HostedServiceA start is running ...");

        await Task.Delay(15000);

        _logger.LogInformation("HostedServiceA start is done");

    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("HostedServiceA stop method called");
        return Task.CompletedTask;
    }
}
