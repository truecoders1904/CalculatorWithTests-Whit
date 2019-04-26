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
        [InlineData(0, -1, -1)]
        public void ShouldSubtractTest(double subtractnumber1, double subtractnumber2, double expectednumber)
        {
            Calculator challenger = new Calculator();

            double actual = challenger.subtract(subtractnumber1, subtractnumber2);

            Assert.Equal(expectednumber, actual);

        }




    }
}
