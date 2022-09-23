using Azure;
using Azure.Core.Diagnostics;
using Azure.Data.Tables;
using Azure.Data.Tables.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AzureTable
{
    public class AzureDemo
    {
        public static void Main()
        {
            //// Construct a new "TableServiceClient using a TableSharedKeyCredential.

            //var serviceClient = new TableServiceClient(
            //    new Uri("https://sep22sa22.table.core.windows.net/project"),
            //    new TableSharedKeyCredential("sep22sa22", "vM1NtpzrvVqvBh80LLDuI0vFUcZtGRRXLPaj29Ejk26XN++djg4bISKlU / 0RzWVVGGre + sWRyVEY + AStuNMROg =="));

            //// Create a new table. The TableItem class stores properties of the created table.
            //string tableName = "OfficeSupplies1p1";
            //TableItem table = serviceClient.CreateTableIfNotExists(tableName);
            //Console.WriteLine($"The created table's name is {table.Name}.");

            //// Use the <see cref="TableServiceClient"> to query the service. Passing in OData filter strings is optional.

            //Pageable<TableItem> queryTableResults = serviceClient.Query(filter: $"TableName eq '{tableName}'");

            //Console.WriteLine("The following are the names of the tables in the query results:");

            //// Iterate the <see cref="Pageable"> in order to access queried tables.

            //foreach (TableItem t in queryTableResults)
            //{
            //    Console.WriteLine(t.Name);
            //}

           // Deletes the table made previously.
            string tableName = "OfficeSupplies1p1";
            serviceClient.DeleteTable(tableName);

            //// Construct a new <see cref="TableClient" /> using a <see cref="TableSharedKeyCredential" />.
            //var tableClient = new TableClient(
            //    new Uri("https://sep22sa22.table.core.windows.net/project"),
            //    tableName,
            //    new TableSharedKeyCredential("sep22sa22", "vM1NtpzrvVqvBh80LLDuI0vFUcZtGRRXLPaj29Ejk26XN++djg4bISKlU / 0RzWVVGGre + sWRyVEY + AStuNMROg =="));

            //// Create the table in the service.
            //tableClient.Create();

            //// Make a dictionary entity by defining a <see cref="TableEntity">.
            //var entity = new TableEntity("partitionKey", "rowKey")
            //{
            //    { "Product", "Marker Set" },
            //    { "Price", 5.00 },
            //    { "Quantity", 21 }
            //};

            //Console.WriteLine($"{entity.RowKey}: {entity["Product"]} costs ${entity.GetDouble("Price")}.");

            //// Add the newly created entity.
            //tableClient.AddEntity(entity);

            //Pageable<TableEntity> queryResultsFilter = tableClient.Query<TableEntity>(filter: $"PartitionKey eq '{partitionKey}'");

            //// Iterate the <see cref="Pageable"> to access all queried entities.
            //foreach (TableEntity qEntity in queryResultsFilter)
            //{
            //    Console.WriteLine($"{qEntity.GetString("Product")}: {qEntity.GetDouble("Price")}");
            //}

            //Console.WriteLine($"The query returned {queryResultsFilter.Count()} entities.");

            //double priceCutOff = 6.00;

            //Pageable<OfficeSupplyEntity> queryResultsLINQ = tableClient.Query<OfficeSupplyEntity>(ent => ent.Price >= priceCutOff);

            //// Delete the entity given the partition and row key.
            //tableClient.DeleteEntity("partitionKey", "rowKey");

            //// Construct a new TableClient using a connection string.

            //var client = new TableClient(
            //    connectionString,
            //    tableName);

            //// Create the table if it doesn't already exist.

            //client.CreateIfNotExists();

            //// Now attempt to create the same table unconditionally.

            //try
            //{
            //    client.Create();
            //}
            //catch (RequestFailedException ex) when (ex.Status == (int)HttpStatusCode.Conflict)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //// Setup a listener to monitor logged events.
            //using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
        }
    }
}
