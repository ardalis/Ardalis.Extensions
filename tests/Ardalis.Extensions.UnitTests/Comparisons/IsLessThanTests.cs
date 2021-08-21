﻿using Ardalis.Extensions.Comparisons;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Comparisons
{
    public class IsLessThanTests
    {
        [Theory]
        [InlineData(7, 5, false)]
        [InlineData(2, 1, false)]
        [InlineData(1, -1, false)]
        [InlineData(1, 1, false)]
        [InlineData(5, 7, true)]
        [InlineData(1, 4, true)]
        [InlineData(-1, 4, true)]
        public void ReturnsExpectedResultGivenValue(int number, int numberToCompare, bool expected)
        {
            var actual = number.IsLessThan(numberToCompare);

            Assert.Equal(expected, actual);
        }
    }
}
