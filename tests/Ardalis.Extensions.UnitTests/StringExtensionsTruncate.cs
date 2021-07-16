using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringManipulationExtensionsTruncate
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsEmptyStringGivenNullOrEmptyString(string input)
        {
            var result = input.Truncate(5);

            Assert.Equal(String.Empty, result);
        }
    }
}
