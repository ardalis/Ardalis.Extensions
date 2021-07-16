using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class IntComparisonExtensionsIsGreaterThan
    {
        [Theory]
        [InlineData(7, 5)]
        [InlineData(2, 1)]
        [InlineData(1, -1)]
        public void ReturnsTrueGivenSmallerNumber(int number, int numberToCompare)
        {
            var result = number.IsGreaterThan(numberToCompare);

            Assert.True(result);
        }                             
    }
}
