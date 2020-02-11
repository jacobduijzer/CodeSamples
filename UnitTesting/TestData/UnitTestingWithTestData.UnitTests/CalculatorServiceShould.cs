using System.Collections.Generic;
using FluentAssertions;
using UnitTestingWithTestData.Core;
using Xunit;

namespace UnitTestingWithTestData.UnitTests
{
    public class CalculatorServiceShould
    {
        private readonly ICalculator _calculator;

        public CalculatorServiceShould() => _calculator = new CalculatorService();

        [Fact]
        public void Construct() => _calculator.Should().BeOfType<CalculatorService>();

        [Theory]
        [MemberData(nameof(TestData))]
        public void AddNumbersFromTestData(double a, double b, double expected) =>
            _calculator.Add(a, b).Should().Be(expected);

        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void SubstractNumbersFromTestClass(double a, double b, double expected) =>
            _calculator.Substract(a, b).Should().Be(expected);

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 12)]
        public void MultiplyNumbersFromInlineData(double a, double b, double expected) =>
            _calculator.Multiply(a, b).Should().Be(expected);

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                1,
                1,
                2
            };
            yield return new object[]
            {
                8,
                3,
                11
            };
        }
    }
}