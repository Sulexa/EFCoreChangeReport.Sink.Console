using EFCoreChangeReport.Configuration;
using EFCoreChangeReport.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EFCoreChangeReport.Sink.Console
{
    public static class EFCoreChangeReportConfigurationExtensions
    {
        public static IEFCoreChangeReportConfiguration ToConsole(this IEFCoreChangeReportConfiguration databaseChangeReportConfiguration)
        {
            if (databaseChangeReportConfiguration == null) throw new ArgumentNullException(nameof(databaseChangeReportConfiguration));

            databaseChangeReportConfiguration.SinkReports += SinkReportsToConsole;

            return databaseChangeReportConfiguration;
        }

        private static void SinkReportsToConsole(List<Report> reports)
        {
            foreach (var report in reports)
            {
                System.Console.WriteLine(JsonConvert.SerializeObject(report));
            }
        }

    }
}
