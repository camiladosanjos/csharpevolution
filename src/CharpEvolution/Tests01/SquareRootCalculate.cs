using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class SquareRootCalculate : ICalculate
    {
        public double Calculate(Options options)
        {
            return Math.Sqrt(options.FirstNumber);
        }
    }
}
