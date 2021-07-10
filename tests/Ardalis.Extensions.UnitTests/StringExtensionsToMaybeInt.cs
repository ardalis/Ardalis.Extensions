using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsToMaybeInt
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsNullGivenNullOrEmptyString(string input)
        {
            var result = input.ToMaybeInt();

            Assert.Equal(null, result);
        }

        [Theory]
        [InlineData("-9999999999999999999999999999999999999")]
        [InlineData("9999999999999999999999999999999999999")]
        public void ReturnsNullGivenOutOfBoundsString(string input)
        {
            var result = input.ToMaybeInt();

            Assert.Equal(null, result);
        }
    }
}
