using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsReplaceString
    {
        [Theory]
        [InlineData("Hello everyone!", "H.llo .v.ryone!", "e", ".", 3)]
        [InlineData("sample sample text", "sample text", "sample ", "", 1)]
        [InlineData("ABCABC", "AABCAABC", "A", "AA", 10)]
        public void ReturnsChangedString(string input, string changedInput, string oldString, string newString, int count)
        {
            Assert.Equal(changedInput, input.ReplaceString(oldString, newString, count));
        }
    }
}
