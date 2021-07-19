// Copyright (c) Microsoft. All rights reserved.

using System.Threading.Tasks;
using Xunit;

namespace MonitoringFunctions.Windows.Functions
{
    public class Ps1Downloader
    {
        private const string _monitorName = "download_ps1";
        private const string _url = "https://dot.net/v1/dotnet-install.ps1";

        [Fact]
        public static async Task DownloadAsync()
        {
            using IDataService dataService = new DataServiceFactory().GetDataService();
            await HelperMethods.CheckAndReportUrlAccessAsync(_monitorName, _url, dataService).ConfigureAwait(false);
        }
    }
}
