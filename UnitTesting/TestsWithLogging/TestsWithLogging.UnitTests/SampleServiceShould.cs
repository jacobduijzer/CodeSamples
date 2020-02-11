using FluentAssertions;
using TestsWithLogging.Core;
using Xunit;
using Xunit.Abstractions;

namespace TestsWithLogging.UnitTests
{
    public class SampleServiceShould
    {
        private readonly SampleService _service;

        public SampleServiceShould(ITestOutputHelper outputHelper) =>
            _service = new SampleService(new TestLogger<SampleService>(outputHelper));

        [Fact]
        public void Construct() =>
            _service.Should().BeOfType<SampleService>();

        [Fact]
        public void WriteToLog() =>
            _service.DoWork(); // check test console for output!
    }
}