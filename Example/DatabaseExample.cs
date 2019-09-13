﻿using OCISDK.Core.src;
using OCISDK.Core.src.Common;
using OCISDK.Core.src.Database;
using OCISDK.Core.src.Database.Request;
using OCISDK.Core.src.Identity;
using OCISDK.Core.src.Identity.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class DatabaseExample
    {
        public static void DatabaseConsoleDisplay(ClientConfig config)
        {
            var identityClient = new IdentityClient(config)
            {
                Region = Regions.US_ASHBURN_1
            };

            var databaseClient = new DatabaseClient(config);

            var listCompartmentRequest = new ListCompartmentRequest() {
                CompartmentId = config.TenancyId,
                CompartmentIdInSubtree = true,
                AccessLevel = ListCompartmentRequest.AccessLevels.ACCESSIBLE
            };
            var compartments = identityClient.ListCompartment(listCompartmentRequest).Items;

            Console.WriteLine("* Database------------------------");
            foreach (var com in compartments)
            {
                if (com.LifecycleState != "ACTIVE") {
                    continue;
                }
                var listDbHomesRequest = new ListDbHomesRequest() {
                    CompartmentId = com.Id,
                    
                };
                var dbHomes = databaseClient.ListDbHomes(listDbHomesRequest).Items;

                foreach (var home in dbHomes)
                {
                    Console.WriteLine($" DatabaseHome: {home.DisplayName}");
                    var listDatabasesRequest = new ListDatabasesRequest()
                    {
                        CompartmentId = com.Id,
                        DbHomeId = home.Id
                    };
                    var databases = databaseClient.ListDatabases(listDatabasesRequest).Items;

                    foreach (var database in databases)
                    {
                        Console.WriteLine($"\t|- name: {database.DbName}");
                        Console.WriteLine($"\t|  state: {database.LifecycleState}");
                        Console.WriteLine($"\t|  lifecycle: {database.LifecycleDetails}");
                        Console.WriteLine($"\t|  time: {database.TimeCreated}");
                    }
                }
            }
        }
    }
}
