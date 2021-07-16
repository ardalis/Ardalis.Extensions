using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class IntComparisonExtensionsIsLessThan
    {
        [Theory]
        [InlineData(4, 5)]
        [InlineData(0, 1)]
        [InlineData(-1, 1)]
        public void ReturnsTrueGivenLargerNumber(int number, int numberToCompare)
        {
            var result = number.IsLessThan(numberToCompare);

            Assert.True(result);
        }                             
    }
}
