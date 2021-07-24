using Ardalis.Extensions.Parsing;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class ParseNullableIntTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsNullGivenNullOrEmptyString(string input)
        {
            var result = input.ParseNullableInt();

            Assert.Null(result);
        }

        [Theory]
        [InlineData("-9999999999999999999999999999999999999")]
        [InlineData("9999999999999999999999999999999999999")]
        public void ReturnsNullGivenOutOfBoundsString(string input)
        {
            var result = input.ParseNullableInt();

            Assert.Null(result);
        }
    }
}