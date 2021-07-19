using Ardalis.Extensions.Strings;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringManipulationExtensionsReplaceWithEmpty
    {
        [Theory]
        [InlineData("bbb", "a")]
        [InlineData("abc", "e")]
        public void ReturnsInputStringIfStringToRemoveDoesNotExist(string input, string stringToRemove)
        {
            var result = input.ReplaceWithEmpty(stringToRemove);

            Assert.Equal(input, result);
        }

        [Theory]
        [InlineData("abc", "a", "bc")]
        [InlineData("steve smith", "s", "teve mith")]
        public void ReturnsInputStringWithoutSubstring(string input, string stringToRemove, string expectedResult)
        {
            var result = input.ReplaceWithEmpty(stringToRemove);

            Assert.Equal(expectedResult, result);
        }
    }
}
