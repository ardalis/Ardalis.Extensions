using Ardalis.Extensions.Parsing;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class TryParseIntTests
    {
        const bool Successful = true;
        const bool NotSuccessful = false;

        [Theory]
        [InlineData("1010435", Successful, 1010435)]
        [InlineData(null, NotSuccessful, 0)]
        [InlineData("", NotSuccessful, 0)]
        [InlineData("9999999999999999999999999999999999999", NotSuccessful, 0)]
        [InlineData("-9999999999999999999999999999999999999", NotSuccessful, 0)]
        public void DependingOnSuccessReturnsExpectedResultGivenValue(string input, bool expectedSuccess, int expectedResult)
        {
            bool actualSuccesss = input.TryParseInt(out int actualResult);

            Assert.Equal(expectedSuccess, actualSuccesss);

            if (actualSuccesss)
            {
                Assert.Equal(expectedResult, actualResult);
            }

        }
    }
}