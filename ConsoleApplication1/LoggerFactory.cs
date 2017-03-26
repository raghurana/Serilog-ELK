using System;
using Serilog;

namespace ConsoleApplication1
{
    public static class LoggerFactory
    {
        private const string OutputFormat = "[{Timestamp:yyyy-MM-dd HH:mm:ss}-{MachineName}-{Level:w3}] {Message}{NewLine}{Exception}";

        private static readonly Lazy<ILogger> LoggerInstance = new Lazy<ILogger>(Builder);

        public static ILogger Logger => LoggerInstance.Value;

        private static ILogger Builder()
        {
            return
                new LoggerConfiguration()
                    .Enrich.WithMachineName()
                    .WriteTo.Trace(outputTemplate: OutputFormat)
                    .WriteTo.LiterateConsole(outputTemplate: OutputFormat)
                    .CreateLogger();
        }
    }
}