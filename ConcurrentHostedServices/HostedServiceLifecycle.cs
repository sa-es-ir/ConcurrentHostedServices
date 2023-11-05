namespace ConcurrentHostedServices;

public class HostedServiceLifecycle : IHostedLifecycleService
{
    private readonly ILogger<HostedServiceLifecycle> _logger;

    public HostedServiceLifecycle(ILogger<HostedServiceLifecycle> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StartAsync is running");
        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StartedAsync is running");
        return Task.CompletedTask;
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StartingAsync is running");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StopAsync is running");
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StoppedAsync is running");
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("StoppingAsync is running");
        return Task.CompletedTask;
    }
}
