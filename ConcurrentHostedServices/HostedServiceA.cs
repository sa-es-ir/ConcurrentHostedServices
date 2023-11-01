namespace ConcurrentHostedServices;

public class HostedServiceA : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        //for (var i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"{i} sec waiting");
        //    await Task.Delay(10000);
        //}
        Console.WriteLine("HostedServiceA start method called");
        await Task.Delay(10000);

    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
