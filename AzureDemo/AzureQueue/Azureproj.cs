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

            // Retrieve the connection string for use with the application. The storage
            // connection string is stored in an environment variable called
            // AZURE_STORAGE_CONNECTION_STRING on the machine running the application.
            // If the environment variable is created after the application is launched
            // in a console or with Visual Studio, the shell or application needs to be
            // closed and reloaded to take the environment variable into account.
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=sep22sa22;AccountKey=vM1NtpzrvVqvBh80LLDuI0vFUcZtGRRXLPaj29Ejk26XN++djg4bISKlU/0RzWVVGGre+sWRyVEY+AStuNMROg==;EndpointSuffix=core.windows.net";

            // Create a unique name for the queue
            string queueName = "quickstartqueues-" + Guid.NewGuid().ToString();

            Console.WriteLine($"Creating queue: {queueName}");

            // Instantiate a QueueClient which will be
            // used to create and manipulate the queue
            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // Create the queue
            await queueClient.CreateAsync();

            Console.WriteLine("\nAdding messages to the queue...");

            // Send several messages to the queue
            await queueClient.SendMessageAsync("First message");
            await queueClient.SendMessageAsync("Second message");

            // Save the receipt so we can update this message later
            SendReceipt receipt = await queueClient.SendMessageAsync("Third message");
        }
    }
}
