namespace ConcurrentHostedServices;

public class HostedServiceB : IHostedService
{
    private readonly ILogger<HostedServiceB> _logger;

    public HostedServiceB(ILogger<HostedServiceB> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("HostedServiceB start method called");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("HostedServiceB stop method called");
        return Task.CompletedTask;
    }
}
