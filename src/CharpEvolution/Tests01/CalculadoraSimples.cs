using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class CalculadoraSimples
    {
        public double Calculate(Options options)
        {
            switch (options.logicalOperator)
            {
                case 1:
                    return new SumCalculate().Calculate(options);
                case 2:
                    return new SubstractCalculate().Calculate(options);
                case 3:
                    if (options.SecondNumber == 0)
                        throw new Exception();
                    else
                        return new DivideCalculate().Calculate(options);
                case 4:
                    return new MultiplyCalculate().Calculate(options);
                case 5:
                    return new PotentiationCalculate().Calculate(options);
                case 6:
                    return new SquareRootCalculate().Calculate(options);
            }

            return 0;
        }
    }
}
