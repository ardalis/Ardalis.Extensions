using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsToInt
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsZeroIntGivenNullOrEmptyString(string input)
        {
            var result = input.ToInt();

            Assert.Equal(0, result);
        }
    }
}
