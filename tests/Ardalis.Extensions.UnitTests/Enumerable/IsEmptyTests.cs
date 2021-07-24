using System.Collections.Generic;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerable
{
    public class IsEmptyTests
    {
        [Fact]
        public void ReturnsTrueGivenEmptyEnumerable()
        {
            IEnumerable<object> enumeration = null;

            var result = enumeration.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void ReturnsFalseGivenEnumerable()
        {
            IEnumerable<int> enumeration = new List<int> { 1, 2, 3, 4 };

            var result = enumeration.IsEmpty();

            Assert.False(result);
        }
    }
}
