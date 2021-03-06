using System;
using Microsoft.Extensions.Options;

namespace ConsoleWithAppConfig
{
    public class SampleService : ISampleService
    {
        private readonly IOptions<ApplicationSettings> _settings;

        public SampleService(IOptions<ApplicationSettings> settings) => _settings = settings;

        public void ShowSettings()
        {
            Console.WriteLine("Settings");
            Console.WriteLine($"TimeOut: {_settings.Value.TimeOut}");
            Console.WriteLine($"BaseUrl: {_settings.Value.BaseUrl}");
        }
    }
}