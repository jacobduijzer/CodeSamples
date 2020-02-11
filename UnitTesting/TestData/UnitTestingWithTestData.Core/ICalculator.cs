namespace UnitTestingWithTestData.Core
{
    public interface ICalculator
    {
       double Add(double a, double b) => a + b;

       double Substract(double a, double b) => a - b;

       double Multiply(double a, double b) => a * b;
    }
}