namespace Ardalis.Extensions.UnitTests.Math
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
        public void Minus_IntToInt_ReturnsExpectedResult(int minuend, int subtrahend, int expectedDifference)
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
        public void Minus_ShortToInt_ReturnsExpectedResult(int minuend, short subtrahend, int expectedDifference)
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
        public void Minus_LongToInt_ReturnsExpectedResult(int minuend, long subtrahend, long expectedDifference)
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
        public void Minus_IntToShort_ReturnsExpectedResult(short minuend, int subtrahend, int expectedDifference)
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
        [InlineData(0, short.MaxValue, short.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Minus_ShortToShort_ReturnsExpectedResult(short minuend, short subtrahend, int expectedDifference)
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
        [InlineData(0, long.MaxValue, long.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, long.MaxValue, long.MinValue)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Minus_LongToShort_ReturnsExpectedResult(short minuend, long subtrahend, long expectedDifference)
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
        [InlineData(0, int.MaxValue, int.MaxValue)]
        [InlineData(long.MaxValue, 1, long.MinValue)]
        [InlineData(long.MinValue, -1, long.MaxValue)]
        [InlineData(1, int.MaxValue, 2147483648)]
        [InlineData(-1, int.MinValue, -2147483649)]
        public void Minus_IntToLong_ReturnsExpectedResult(long minuend, int subtrahend, long expectedDifference)
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
        [InlineData(0, short.MaxValue, short.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Minus_ShortToLong_ReturnsExpectedResult(long minuend, short subtrahend, long expectedDifference)
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
        [InlineData(0, long.MaxValue, long.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, long.MaxValue, long.MinValue)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Minus_LongToLong_ReturnsExpectedResult(long minuend, long subtrahend, long expectedDifference)
        {
            // Arrange

            // Act
            long actualDifference = minuend.Minus(subtrahend);

            // Assert
            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}