using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorWithTests.tests
{
    public class Calculatingtests
    {
        [Theory]
        [InlineData(100, 50, 150)]
        [InlineData(45.5, 65, 110.5)]
        [InlineData(0, -1, -1)]
        public void ShouldAddTest(double number1, double number2, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.AdditionNumber(number1, number2);

            Assert.Equal(expectednumber, actual);

        }
        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(45.5, 65, -19.5)]
        [InlineData(0, -1, 1)]
        public void ShouldSubtractTest(double subtractnumber1, double subtractnumber2, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.subtract(subtractnumber1, subtractnumber2);

            Assert.Equal(expectednumber, actual);

        }
        [Theory]
        [InlineData(100, 50, 5000)]
        [InlineData(45.5, 65, 2957.5)]
        [InlineData(0, -1, 0)]
        public void ShouldMultipyTest(double multiplynumber1, double multiplynumber2, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.multiply(multiplynumber1, multiplynumber2);

            Assert.Equal(expectednumber, actual);

        }
        [Theory]
        [InlineData(100, 50, 2)]
        [InlineData(45.5, 65, .7)]
        [InlineData(0, -1, 0)]
        public void ShouldDivideTest(double dividenumber1, double dividenumber2, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.divide(dividenumber1, dividenumber2);

            Assert.Equal(expectednumber, actual);

        }
        [Theory]
        [InlineData(10, 3628800)]
        [InlineData(4, 24)]
        [InlineData(0, 0)]
        public void ShouldfactorialTest(double factor1, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.factorial(factor1);

            Assert.Equal(expectednumber, actual);

        }








    }
}
