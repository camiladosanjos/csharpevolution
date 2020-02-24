using CsharpEvolution.Tests01;
using System;

namespace CharpEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test01
            var options = new Options();

            Console.WriteLine("Enter the first number");
            options.FirstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            options.SecondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Type 1 to SUM");
            Console.WriteLine("Type 2 to SUBTRACT");
            Console.WriteLine("Type 3 to DIVIDE");
            Console.WriteLine("Type 4 to MULTIPLY");
            Console.WriteLine("Type 5 to POTENTIY");
            Console.WriteLine("Type 6 to SQUARE ROOT");
            Console.WriteLine("Type 7 to exit");

            options.logicalOperator = int.Parse(Console.ReadLine());

            var result = new CalculadoraSimples()
                .Calculate(options);

            Console.WriteLine("O resultado da operação é: " + result);
        }
    }
}
