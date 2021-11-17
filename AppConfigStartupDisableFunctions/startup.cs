using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

[assembly: FunctionsStartup(typeof(AppConfigStartupDisableFunctions.Startup))]

namespace AppConfigStartupDisableFunctions
{
    class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            string connectionString = Environment.GetEnvironmentVariable("AppConfigConnectionString");//"{AppConfigConnString}";
            builder.ConfigurationBuilder.AddAzureAppConfiguration(connectionString);
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
        }
    }
}