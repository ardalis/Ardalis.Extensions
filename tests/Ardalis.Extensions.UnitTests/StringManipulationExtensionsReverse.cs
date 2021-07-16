using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringManipulationExtensionsReverse
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsEmptyStringGivenNullOrEmptyString(string input)
        {
            string result = input.Right(2);

            Assert.Equal(String.Empty, result);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("abcde", "edcba")]
        public void ReturnsReversedString(string input, string expectedResult)
        {
            string result = input.Reverse();

            Assert.Equal(expectedResult, result);
        }
    }
}
