using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Threading;

namespace ConfigurationHost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            await host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            var myhost = Host.CreateDefaultBuilder(args);
                myhost.ConfigureAppConfiguration(
                 (hostcontext, config) =>
                 {
                     config.Sources.Clear();
                     IHostEnvironment env = hostcontext.HostingEnvironment;

                     config.AddJsonFile("appsettings.json", optional: false, true);
                     config.AddJsonFile($"appsettins.{env.EnvironmentName}.json", true, true);
                     IConfigurationRoot confRoot = config.Build();

                     myhost.ConfigureServices((servicesCol)=> { servicesCol.Configure<TransientFaultHandlingOptions>(confRoot.GetSection(key: nameof(TransientFaultHandlingOptions))); });
                 });
            return myhost;
        }
    }
}
