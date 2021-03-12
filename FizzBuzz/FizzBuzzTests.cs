using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [Theory]
        public void ShouldReturnRegularNumber(int input, string expected)
        {
            var result = FizzBuzz.Calculate(input);

            Assert.Equal(expected, result);
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

