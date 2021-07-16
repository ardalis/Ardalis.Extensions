using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class IntExtensionsIsGreaterThan
    {
        [Theory]
        [InlineData(7)]
        public void IsGreaterThan_GivenNumberGreater_ShouldReturnsTrue(int number)
        {
            var result = number.IsGreaterThan(5);

            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        public void IsGreaterThan_GivenNumberLess_ShouldReturnsFalse(int number)
        {
            var result = number.IsGreaterThan(4);

            Assert.False(result);
        }

        [Theory]
        [InlineData(2)]
        public void IsGreaterThan_GivenNumberEqual_ShouldReturnsFalse(int number)
        {
            var result = number.IsGreaterThan(2);

            Assert.False(result);
        }
    }
}
