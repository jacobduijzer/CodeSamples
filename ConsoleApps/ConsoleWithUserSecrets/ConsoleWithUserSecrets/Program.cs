using System;
using System.IO;
using ConsoleWithUserSecrets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleWithAppConfig
{
    class Program
    {
        public static IConfiguration Configuration { get; private set; }

        static void Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddUserSecrets<Program>()
                .Build();

            var serviceProvider = ConfigureServices();

            var sampleService = serviceProvider.GetService<ISampleService>();
            sampleService.ShowSettings();
        }

        private static IServiceProvider ConfigureServices() =>
            new ServiceCollection()
                .AddScoped<ISampleService, SampleService>()
                .Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"))
                .BuildServiceProvider();
    }
}