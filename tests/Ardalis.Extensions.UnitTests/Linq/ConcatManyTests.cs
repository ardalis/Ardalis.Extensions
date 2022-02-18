using Xunit;
using System;
using System.Collections.Generic;

using Ardalis.Extensions.Linq;

namespace Ardalis.Extensions.UnitTests.Linq
{
    public class ConcatManyTests
    {
        [Fact]
        public void ConcatSequenceInRightOrder()
        {
            // Arrange
            IEnumerable<int> firstIterator = new[] { 1, 2, };
            IEnumerable<int> secondIterator = new[] { 3, 4 };
            IEnumerable<int> thirdIterator = new[] { 5, 6 };
            IEnumerable<int> fourthIterator = new[] { 7, 8 };

            IEnumerable<int> expectedIterator = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Act
            var combinedIterator = firstIterator.ConcatMany(new[] { secondIterator, thirdIterator, fourthIterator });

            // Assert
            Assert.Equal(expectedIterator, combinedIterator);
        }

        [Fact]
        public void ThrowsArgumentNullException_OnBaseIterator()
        {
            // Arrange
            IEnumerable<int> baseIterator = null;

            // Act
            Action action = () => baseIterator.ConcatMany(new[] { 42 });

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void ThrowsArgumentNullException_OnConcatIterators()
        {
            // Arrange
            IEnumerable<int> baseIterator = new[] { 42 };

            // Act
            Action action = () => baseIterator.ConcatMany(null);

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
