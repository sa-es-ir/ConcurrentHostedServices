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
        _logger.LogInformation("HostedServiceA start method called");
        await Task.Delay(5000);

    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("HostedServiceA stop method called");
        return Task.CompletedTask;
    }
}
