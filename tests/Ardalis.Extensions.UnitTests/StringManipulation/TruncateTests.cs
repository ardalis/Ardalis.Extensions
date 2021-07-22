using Ardalis.Extensions.StringManipulation;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringManipulation
{
    public class TruncateTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ReturnsEmptyStringGivenNullOrEmptyString(string input)
        {
            var result = input.Truncate(5);

            Assert.Equal(string.Empty, result);
        }
    }
}