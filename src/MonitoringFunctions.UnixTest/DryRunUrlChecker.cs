// Copyright (c) Microsoft. All rights reserved.

using System.Threading.Tasks;
using Xunit;

namespace MonitoringFunctions.Linux.Functions
{
    /// <summary>
    /// Runs the shell script in -DryRun mode and checks whether the generated links are accessible
    /// </summary>
    public class DryRunUrlChecker
    {
        [Fact]
        public static async Task RunLTSAsync()
        {
            string monitorName = "dry_run_sh_LTS";
            string cmdArgs = "-c LTS";

            await HelperMethods.ExecuteDryRunCheckAndReportUrlAccessAsync(monitorName, cmdArgs).ConfigureAwait(false);
        }

        [Fact]
        public static async Task Run3_1Async()
        {
            string monitorName = "dry_run_sh_3_1";
            string cmdArgs = "-c 3.1";

            await HelperMethods.ExecuteDryRunCheckAndReportUrlAccessAsync(monitorName, cmdArgs).ConfigureAwait(false);
        }

        [Fact]
        public static async Task Run3_0RuntimeAsync()
        {
            string monitorName = "dry_run_sh_3_0_runtime";
            string cmdArgs = "-c 3.0 -Runtime dotnet";

            await HelperMethods.ExecuteDryRunCheckAndReportUrlAccessAsync(monitorName, cmdArgs).ConfigureAwait(false);
        }
    }
}
