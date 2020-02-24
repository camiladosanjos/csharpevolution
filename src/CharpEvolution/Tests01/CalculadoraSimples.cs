using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class CalculadoraSimples
    {
        public double Calculate(Options options)
        {
            double result = 0;

            switch (options.logicalOperator)
            {
                case 1:
                    result = new SumCalculate().Calculate(options.FirstNumber, options.SecondNumber);
                    break;
                case 2:
                    result = new SubstractCalculate().Calculate(options.FirstNumber, options.SecondNumber);
                    break;
                case 3:
                    if (options.SecondNumber == 0)
                        throw new Exception();
                    else
                        result = new DivideCalculate().Calculate(options.FirstNumber, options.SecondNumber);
                    break;
                case 4:
                    result = new MultiplyCalculate().Calculate(options.FirstNumber, options.SecondNumber);
                    break;
                case 5:
                    result = new PotentiationCalculate().Calculate(options.FirstNumber, options.SecondNumber);
                    break;
                case 6:
                    result = new SquareRootCalculate().Calculate(options.FirstNumber);
                    break;
            }

            return result;
        }
    }
}
