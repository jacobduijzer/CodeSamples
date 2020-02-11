using System.Reflection;
using Microsoft.Extensions.Logging;

namespace TestsWithLogging.Core
{
    public class SampleService : ISampleService
    {
        private readonly ILogger<SampleService> _logger;

        public SampleService(ILogger<SampleService> logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.LogInformation($"Start: {MethodBase.GetCurrentMethod().Name}");
            _logger.LogInformation($"Done: {MethodBase.GetCurrentMethod().Name}");
        }

    }
}