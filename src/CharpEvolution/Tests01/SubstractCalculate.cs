using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    class SubstractCalculate : ICalculate
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
