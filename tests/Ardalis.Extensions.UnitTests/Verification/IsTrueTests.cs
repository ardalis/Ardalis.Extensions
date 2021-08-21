using Ardalis.Extensions.Verification;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Verification
{
    public class IsTrueTests
    {
        [Fact]
        public void ReturnsTrueGivenTrueCondition()
        {
            var condition = 1 == 1;
            var result = condition.IsTrue();

            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseGivenFalseCondition()
        {
            var condition = 1 == 2;
            var result = condition.IsTrue();

            Assert.False(result);
        }
    }
}
