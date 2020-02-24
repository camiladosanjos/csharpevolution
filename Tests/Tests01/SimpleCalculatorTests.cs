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
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(1, 5, 1);
            var expectancy = 6;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Sum_two_numbers_to_decimal_places()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(1.5, 0.5, 1);
            var expectancy = 2;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Subtract_two_whole_numbers()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(8, 3, 2);
            var expectancy = 5;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Subtract_two_numbers_to_decimal_places()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(1.5, 0.5, 2);
            var expectancy = 1;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Divide_two_whole_numbers()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(10, 2, 3);
            var expectancy = 5;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Divide_two_numbers_to_decimal_places()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(11.3, 0.5, 3);
            var expectancy = 22.6;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Divide_by_zero_shall_exception()
        {
            Assert.Throws<Exception>(() => new CalculadoraSimples().Calculate(1, 0, 3));
        }

        [Fact]
        public void Multiply_two_whole_numbers()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(66, 8, 4);
            var expectancy = 528;

            Assert.Equal(resultFound, expectancy);
        }

        [Fact]
        public void Multiply_two_numbers_to_decimal_places()
        {
            var calculator = new CalculadoraSimples();
            var resultFound = calculator.Calculate(8.3, 9.3, 4);
            var expectancy = 77.19000000000001;

            Assert.Equal(resultFound, expectancy);
        }
    }
}
