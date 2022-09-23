using Azure;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using System;
using System.Threading.Tasks;

namespace QueuesQuickstartV12
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Azure Queue Storage client library v12 - .NET quickstart sample\n");
            Console.WriteLine("Enter Queue Name");
            string queueName = Console.ReadLine();
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=sep22sa22;AccountKey=vM1NtpzrvVqvBh80LLDuI0vFUcZtGRRXLPaj29Ejk26XN++djg4bISKlU/0RzWVVGGre+sWRyVEY+AStuNMROg==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionString, queueName);
            PeekedMessage[] peekedMessages = await queueClient.PeekMessagesAsync(maxMessages: 10);
            foreach (PeekedMessage peekedMessage in peekedMessages)
            {
                // Display the message
                Console.WriteLine($"Message: {peekedMessage.MessageText}");
            }
        }
    }
}
