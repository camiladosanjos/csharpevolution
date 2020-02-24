using CsharpEvolution.Tests01;
using System;
using Xunit;

namespace Tests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void Sum_two_whole_numbers()
        {
            var options = new Options()
            {
                FirstNumber = 1,
                SecondNumber = 5,
                logicalOperator = 1
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 6;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Sum_two_numbers_to_decimal_places()
        {
            var options = new Options()
            {
                FirstNumber = 1.5,
                SecondNumber = 0.5,
                logicalOperator = 1
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 2;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Subtract_two_whole_numbers()
        {
            var options = new Options()
            {
                FirstNumber = 8,
                SecondNumber = 3,
                logicalOperator = 2
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 5;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Subtract_two_numbers_to_decimal_places()
        {
            var options = new Options()
            {
                FirstNumber = 1.5,
                SecondNumber = 0.5,
                logicalOperator = 2
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 1;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Divide_two_whole_numbers()
        {
            var options = new Options()
            {
                FirstNumber = 10,
                SecondNumber = 2,
                logicalOperator = 3
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 5;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Divide_two_numbers_to_decimal_places()
        {
            var options = new Options()
            {
                FirstNumber = 11.3,
                SecondNumber = 0.5,
                logicalOperator = 3
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 22.6;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Divide_by_zero_shall_exception()
        {
            var options = new Options()
            {
                FirstNumber = 1,
                SecondNumber = 0,
                logicalOperator = 3
            };

            Assert.Throws<Exception>(() => new CalculadoraSimples().Calculate(options));
        }

        [Fact]
        public void Multiply_two_whole_numbers()
        {
            var options = new Options()
            {
                FirstNumber = 66,
                SecondNumber = 8,
                logicalOperator = 4
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 528;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void Multiply_two_numbers_to_decimal_places()
        {
            var options = new Options()
            {
                FirstNumber = 8.3,
                SecondNumber = 9.4,
                logicalOperator = 4
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 78.02000000000001;

            Assert.Equal(resultFound, expected); 
        }
        //Todo
        [Fact]
        public void Potentiation_two_whole_numbers()
        {
            var options = new Options()
            {
                FirstNumber = 5,
                SecondNumber = 4,
                logicalOperator = 5
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 625;

            Assert.Equal(resultFound, expected);
        }

        [Fact]
        public void SquareRoot()
        {
            var options = new Options()
            {
                FirstNumber = 5,
                logicalOperator = 6
            };

            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(options);
            var expected = 2.23606797749979;

            Assert.Equal(resultFound, expected);
        }
    }
}
