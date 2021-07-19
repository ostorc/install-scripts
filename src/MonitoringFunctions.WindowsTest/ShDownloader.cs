// Copyright (c) Microsoft. All rights reserved.

using System.Threading.Tasks;
using Xunit;

namespace MonitoringFunctions.Windows.Functions
{
    public class ShDownloader
    {
        private const string _monitorName = "download_sh";
        private const string _url = "https://dot.net/v1/dotnet-install.sh";

        [Fact]
        public static async Task RunAsync()
        {
            using IDataService dataService = new DataServiceFactory().GetDataService();
            await HelperMethods.CheckAndReportUrlAccessAsync(_monitorName, _url, dataService).ConfigureAwait(false);
        }
    }
}
