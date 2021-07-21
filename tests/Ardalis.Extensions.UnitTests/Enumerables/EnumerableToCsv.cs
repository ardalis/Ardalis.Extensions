using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ardalis.Extensions.Enumerables;

namespace Ardalis.Extensions.UnitTests.Enumerables
{
    public class EnumerableToCsv
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
