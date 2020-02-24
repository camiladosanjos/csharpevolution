using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class PotentiationCalculate : ICalculate
    {
        public double Calculate(Options options)
        {
            return Math.Pow(options.FirstNumber, options.SecondNumber);
        }
    }
}
