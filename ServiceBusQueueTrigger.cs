using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class ServiceBusQueueTrigger
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public static void Run([ServiceBusTrigger("queue", Connection = "SERVICEBUS_CONNECTION")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
