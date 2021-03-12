using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests2
    {
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [Theory]
        public void ShouldReturnRegularNumber(int input, string expected)
        {
            var result = FizzBuzz.Calculate(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenDividedBy3ReturnFizz()
        {
            var result = FizzBuzz.Calculate(3);

            Assert.Equal("Fizz", result);
        }
    }
    public class FizzBuzz
    {
        public static string Calculate(int number)
        {
            return number.ToString();
        }
    }
}

