﻿namespace Ardalis.Extensions.UnitTests.Math
{
    using Xunit;
    using Ardalis.Extensions.Math;

    public class MinusTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, int.MaxValue, -2147483647)]
        [InlineData(int.MaxValue, 1, 2147483646)]
        [InlineData(int.MinValue, -1, -2147483647)]
        [InlineData(1, int.MaxValue, -2147483646)]
        [InlineData(-1, int.MinValue, int.MaxValue)]
        public void Minus_IntFromInt_ReturnsExpectedResult(int minuend, int subtrahend, int expectedDifference)
        {
            // Arrange

            // Act
            int actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, short.MaxValue, -32767)]
        [InlineData(int.MaxValue, 1, 2147483646)]
        [InlineData(int.MinValue, -1, -2147483647)]
        [InlineData(1, short.MaxValue, -32766)]
        [InlineData(-1, short.MinValue, short.MaxValue)]
        public void Minus_ShortFromInt_ReturnsExpectedResult(int minuend, short subtrahend, int expectedDifference)
        {
            // Arrange

            // Act
            int actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, long.MaxValue, -9223372036854775807)]
        [InlineData(int.MaxValue, 1, 2147483646)]
        [InlineData(int.MinValue, -1, -2147483647)]
        [InlineData(1, long.MaxValue, -9223372036854775806)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Minus_LongFromInt_ReturnsExpectedResult(int minuend, long subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, int.MaxValue, -2147483647)]    
        [InlineData(short.MaxValue, 1, 32766)]
        [InlineData(short.MinValue, -1, -32767)]
        [InlineData(1, short.MaxValue, -32766)]
        [InlineData(-1, short.MinValue, 32767)]
        public void Minus_IntFromShort_ReturnsExpectedResult(short minuend, int subtrahend, int expectedDifference)
        {
            // Arrange

            // Act
            int actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, short.MaxValue, -32767)]
        [InlineData(short.MaxValue, 1, 32766)]
        [InlineData(short.MinValue, -1, -32767)]
        [InlineData(1, short.MaxValue, -32766)]
        [InlineData(-1, short.MinValue, 32767)]
        public void Minus_ShortFromShort_ReturnsExpectedResult(short minuend, short subtrahend, int expectedDifference)
        {
            // Arrange

            // Act
            int actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, long.MaxValue, -9223372036854775807)]
        [InlineData(short.MaxValue, 1, 32766)]
        [InlineData(short.MinValue, -1, -32767)]
        [InlineData(1, long.MaxValue, -9223372036854775806)]
        [InlineData(-1, long.MinValue, 9223372036854775807)]
        public void Minus_LongFromShort_ReturnsExpectedResult(short minuend, long subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, int.MaxValue, -2147483647)]
        [InlineData(long.MaxValue, 1, 9223372036854775806)]
        [InlineData(long.MinValue, -1, -9223372036854775807)]
        [InlineData(1, int.MaxValue, -2147483646)]
        [InlineData(-1, int.MinValue, 2147483647)]
        public void Minus_IntFromLong_ReturnsExpectedResult(long minuend, int subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, short.MaxValue, -32767)]
        [InlineData(short.MaxValue, 1, 32766)]
        [InlineData(short.MinValue, -1, -32767)]
        [InlineData(1, short.MaxValue, -32766)]
        [InlineData(-1, short.MinValue, 32767)]
        public void Minus_ShortFromLong_ReturnsExpectedResult(long minuend, short subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(1, -2, 3)]
        [InlineData(0, long.MaxValue, -9223372036854775807)]
        [InlineData(long.MaxValue, 1, 9223372036854775806)]
        [InlineData(long.MinValue, -1, -9223372036854775807)]
        [InlineData(1, long.MaxValue, -9223372036854775806)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Minus_LongFromLong_ReturnsExpectedResult(long minuend, long subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}