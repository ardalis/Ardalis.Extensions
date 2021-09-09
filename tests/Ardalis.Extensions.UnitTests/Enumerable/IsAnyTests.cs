using System.Collections.Generic;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables
{
    public class IsAnyTests
    {
        [Fact]
        public void ReturnsTrueGivenEnumerableThatHaveValues()
        {
            IEnumerable<int> enumeration = new List<int> { 1, 2, 3, 4 };

            var result = enumeration.IsAny();

            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseGivenEmptyEnumerable()
        {
            IEnumerable<object> enumeration = null;

            var result = enumeration.IsAny();

            Assert.False(result);
        }
    }
}
