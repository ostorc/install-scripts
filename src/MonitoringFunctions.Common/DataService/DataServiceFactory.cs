// Copyright (c) Microsoft. All rights reserved.

using MonitoringFunctions.Providers;
using System;

namespace MonitoringFunctions
{
    public sealed class DataServiceFactory
    {
        public IDataService GetDataService()
        {
            string? environment = Environment.GetEnvironmentVariable("AZURE_FUNCTIONS_ENVIRONMENT");

            if(environment == "Development")
            {
                return new DummyDataService();
            }
            else
            {
                return new DummyDataService();
            }
        }
    }
}
