using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function;

public class ServiceBusQueueTrigger
{
    private readonly ILogger<ServiceBusQueueTrigger> _logger;

    public ServiceBusQueueTrigger(ILogger<ServiceBusQueueTrigger> logger)
    {
        _logger = logger;
    }

    [Function("ServiceBusQueueTrigger")]
    public void Run(
        [ServiceBusTrigger("queue", Connection = "SERVICEBUS_CONNECTION")] string myQueueItem)
    {
        _logger.LogInformation("C# ServiceBus queue trigger function processed message: {Message}", myQueueItem);
    }
}
