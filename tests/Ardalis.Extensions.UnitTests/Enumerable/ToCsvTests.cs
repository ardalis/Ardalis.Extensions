using Ardalis.Extensions.Enumerables;
using System.Collections.Generic;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables
{
    public class ToCsvTests
    {
        [Fact]
        public void ReturnsEmptyStringGivenEmptyEnumerable()
        {
            IEnumerable<int> enumaration = null;

            var result = enumaration.ToCsv();

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReturnsCsvGivenEnumerable()
        {
            IEnumerable<int> enumaration = new List<int>() { 1, 2, 3, 4, 5 };

            var result = enumaration.ToCsv();

            Assert.Equal("1,2,3,4,5", result);
        }
    }
}
