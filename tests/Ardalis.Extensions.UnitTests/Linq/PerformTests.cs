using Ardalis.Extensions.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Linq
{
    public class PerformTests
    {
        [Fact]
        public void ThrowsGivenNullInput()
        {
            IEnumerable<object> enumeration = null;

            Action action = () => enumeration.Perform(x => x.ToString()).ToList();

            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void ThrowsGivenNullAction()
        {
            IEnumerable<object> enumeration = new List<object>();

            Func<object, object> operation = null;

            Action action = () => enumeration.Perform(operation).ToList();

            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void ExecutesActionOncePerItem()
        {
            IEnumerable<int> input = new List<int> { 1, 2, 3 };
            var sum = 0;
            Func<int, int> operation = (int x) => sum += x;

            input.Perform(operation).ToList();

            Assert.Equal(6, sum);
        }

        [Fact]
        public void ResultsCanBeUsedWithOtherLinqExpressions()
        {
            //Arrange
            IEnumerable<int> input = new List<int> { 1, 2, 3 };

            var sum = 0;
            Func<int, int> operation = (int x) => sum += x;

            //Act
            var results = input.Perform(operation).Reverse().ToList();

            var inspectors = new Action<int>[]{
                (e) => Assert.Equal(6, e),
                (e) => Assert.Equal(3, e),
                (e) => Assert.Equal(1, e)};

            //Assert
            Assert.Collection(results, inspectors);
        }
    }
}