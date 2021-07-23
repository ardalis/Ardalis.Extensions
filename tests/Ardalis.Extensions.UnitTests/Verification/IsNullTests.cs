using Ardalis.Extensions.Verification;
using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Checking
{
    public class IsNullTests
    {
        [Theory]
        [InlineData(null)]
        public void ReturnsTrueGivenNull(object value)
        {
            var result = value.IsNull();

            Assert.True(result);
        }

        [Theory]
        [InlineData("text")]
        [InlineData(45)]
        [InlineData(true)]
        public void ReturnsFalseGivenValue(object value)
        {
            var result = value.IsNull();

            Assert.False(result);
        }
    }
}
