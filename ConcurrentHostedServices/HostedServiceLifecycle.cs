namespace ConcurrentHostedServices;

public class HostedServiceLifecycle : IHostedLifecycleService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StartAsync is running");
        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StartedAsync is running");
        return Task.CompletedTask;
    }

    public Task StartingAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StartingAsync is running");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StopAsync is running");
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StoppedAsync is running");
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("StoppingAsync is running");
        return Task.CompletedTask;
    }
}
