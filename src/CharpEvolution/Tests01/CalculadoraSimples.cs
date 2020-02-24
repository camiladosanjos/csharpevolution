using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class CalculadoraSimples
    {
        public void ReadConsole()
        {
            Console.WriteLine("Enter the first number");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            var secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Type 1 to SUM");
            Console.WriteLine("Type 2 to SUBTRACT");
            Console.WriteLine("Type 3 to DIVIDE");
            Console.WriteLine("Type 4 to MULTIPLY");
            Console.WriteLine("Type 5 to exit");

            var logicalOperator = int.Parse(Console.ReadLine());

            Calculate(firstNumber, secondNumber, logicalOperator);
        }

        public double Calculate(double firstNumber, double secondNumber, int logicalOperator)
        {
            double result = 0;

            switch (logicalOperator)
            {
                case 1:
                    result = new SumCalculate().Calculate(firstNumber, secondNumber);
                    break;
                case 2:
                    result = new SubstractCalculate().Calculate(firstNumber, secondNumber);
                    break;
                case 3:
                    if (secondNumber == 0)
                        throw new Exception();
                    else
                        result = new DivideCalculate().Calculate(firstNumber, secondNumber);
                    break;
                case 4:
                    result = new MultiplyCalculate().Calculate(firstNumber, secondNumber);
                    break;
            }
            Console.WriteLine("O resultado da operação é: " + result);
            return result;
        }
    }
}
