using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Test der Addition")]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, models.CalculationType.ADDITION);
            Assert.Equal(5.0m, result);
        }

        [Fact(DisplayName = "Test der Subtraktion")]
        public void TestSubtraktion()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, models.CalculationType.SUBTRACTION);
            Assert.Equal(-2.0m, result);
        }
        [Fact(DisplayName = "Test der Mulitpilaktion")]
        public void TestMulitpilaktion()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(1.5m, 3.5m, models.CalculationType.MULTIPLICATION);
            Assert.Equal(5.25m, result);
        }

        [Fact(DisplayName = "Test der Divison")]
        public void TestDivisonn()
        {
            Calculator.models.Calculator calc = new models.Calculator();
            decimal result = calc.Calculate(5.0m, 2.0m, models.CalculationType.DIVISTION);
            Assert.Equal(2.5m, result);
        }
    }
}
