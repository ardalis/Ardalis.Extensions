using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class IntExtensionsIsGreaterThan
    {
        [Theory]
        [InlineData(7)]
        public void IsGreaterThan_GivenNumber_ShouldReturnsTrue(int number)
        {
            var result = number.IsGreaterThan(5);

            Assert.True(result);
        }                             
    }
}
