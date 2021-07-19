using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Ardalis.Extensions.Arrays;

namespace Ardalis.Extensions.UnitTests.Arrays
{
    public class IntArrayExtensions
    {
        [Theory]
        [InlineData(new int[0])]
        public void ReturnsEmptyArrayGivenAnArray(int[] input)
        {
            var result = input.OddNumbers();

            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        public void ReturnsOddNumbersGivenAnArray(int[] input)
        {
            var result = input.OddNumbers();

            Assert.Equal(result, new[] { 1, 3, 5 });
        }

        [Theory]
        [InlineData(new[] { 6, 7, 8, 9, 10, 11 })]
        public void ReturnsEvenNumbersGivenAnArray(int[] input)
        {
            var result = input.EvenNumbers();

            Assert.Equal(result, new[] { 6, 8, 10 });
        }
    }
}
