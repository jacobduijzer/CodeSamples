using System;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace TestsWithLogging.UnitTests
{
    public class TestLogger<T> : ILogger<T>, IDisposable
    {
        private ITestOutputHelper _output;

        public TestLogger(ITestOutputHelper output) => _output = output;

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatter) =>
                _output.WriteLine(state.ToString());

        public bool IsEnabled(LogLevel logLevel) => true;

        public IDisposable BeginScope<TState>(TState state) => this;

        public void Dispose()
        {
        }
    }
}