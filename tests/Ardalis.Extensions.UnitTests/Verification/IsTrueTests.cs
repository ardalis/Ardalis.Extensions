using Ardalis.Extensions.Verification;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Verification
{
    public class IsTrueTests
    {
        [Theory]
        [InlineData(true)]
        public void ReturnsTrueGivenTrueCondition(bool condition)
        {
            var result = condition.IsTrue();

            Assert.True(result);
        }

        [Theory]
        [InlineData(1 == 2)]
        public void ReturnsFalseGivenFalseCondition(bool condition)
        {
            var result = condition.IsTrue();

            Assert.False(result);
        }
    }
}
