using System;
using System.Collections.Generic;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public double AdditionNumber(double number1, double number2)         {             return number1 + number2;         }
        public double subtract(double subtractnumber1, double subtractnumber2)         {             return subtractnumber1 - subtractnumber2;         }          public double multiply(double multiplynumber1, double multiplynumber2)         {             return multiplynumber1 * multiplynumber2;         }         public double divide(double dividenumber1, double dividenumber2)         {             return dividenumber1 / dividenumber2;         }          public double factorial(double factor1)         {
            double fact = factor1;             for (double i = factor1 - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            return fact;         } 
    }
}
