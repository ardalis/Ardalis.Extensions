using Ardalis.Extensions.Comparable;
using Xunit;


namespace Ardalis.Extensions.UnitTests.Camparable
{
    public class IsGreaterThanTests
    {
        [Theory]
        [InlineData(7, 5, true)]
        [InlineData(2, 1, true)]
        [InlineData(1, -1, true)]
        [InlineData(1, 1, false)]
        [InlineData(5, 7, false)]
        [InlineData(1, 4, false)]
        [InlineData(-1, 4, false)]
        public void ReturnsExpectedResultGivenValue(int number, int numberToCompare, bool expected)
        {
            var actual = number.IsGreaterThan(numberToCompare);

            Assert.Equal(expected, actual);
        }
    }
}