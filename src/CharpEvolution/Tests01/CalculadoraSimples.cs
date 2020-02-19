using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class CalculadoraSimples
    {
        public void ReadConsoleAndCalculate()
        {
            Console.WriteLine("Enter the first number");
            var firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            var secondNumber = double.Parse(Console.ReadLine());

            Calculate(firstNumber, secondNumber);
        }

        private void Calculate(double firstNumber, double secondNumber)
        {
            var resultado = 0;

            while (resultado < 5)
            {
                Console.WriteLine("Type 1 to SUM");
                Console.WriteLine("Type 2 to SUBTRACT");
                Console.WriteLine("Type 3 to DIVIDE");
                Console.WriteLine("Type 4 to MULTIPLY");
                Console.WriteLine("Type 5 to exit");

                resultado = int.Parse(Console.ReadLine());

                switch (resultado)
                {
                    case 1:
                        Console.WriteLine("Soma: {0}", firstNumber + secondNumber);
                        break;
                    case 2:
                        Console.WriteLine("Subtração: {0}", firstNumber - secondNumber);
                        break;
                    case 3:
                        if (secondNumber == 0)
                            Console.WriteLine("Cannot divide by zero!");
                        else    
                            Console.WriteLine("Divisão: {0}", firstNumber / secondNumber);
                        break;
                    case 4:
                        Console.WriteLine("Multiplicação: {0}", firstNumber * secondNumber);
                        break;
                }
            }
        }     
    }
}
