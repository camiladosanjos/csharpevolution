using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class DivideCalculate : ICalculate
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber/secondNumber;
        }
    }
}
