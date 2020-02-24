using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class SquareRootCalculate : ICalculate
    {
        public double Calculate(double firstNumber, double secondNumber = 0)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
