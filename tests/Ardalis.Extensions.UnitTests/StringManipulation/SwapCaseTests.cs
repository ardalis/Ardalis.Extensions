using Ardalis.Extensions.StringManipulation;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringManipulation
{
    public class SwapCaseTests
    {
        [Theory]
        [InlineData("Hello everyone!", "hELLO EVERYONE!")]
        [InlineData("HELLO", "hello")]
        [InlineData("hello", "HELLO")]
        public void ReturnsSwappedCaseString(string input, string sawppedCaseInput)
        {
            Assert.Equal(sawppedCaseInput, input.SwapCase());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void ReturnsNotSwappedCaseStringIfNullOrEmpty(string input, string sawppedCaseInput)
        {
            Assert.Equal(sawppedCaseInput, input.SwapCase());
        }

        [Theory]
        [InlineData("!@@#$#$%%^", "!@@#$#$%%^")]
        [InlineData("\"'", "\"'")]
        public void ReturnsNotSwappedCaseStringIfSpecialCharacter(string input, string sawppedCaseInput)
        {
            Assert.Equal(sawppedCaseInput, input.SwapCase());
        }
    }
}
