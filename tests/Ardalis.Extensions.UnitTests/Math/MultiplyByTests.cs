namespace Ardalis.Extensions.UnitTests.Math
{
    using Xunit;
    using Ardalis.Extensions.Math;

    public class MultiplyByTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, int.MaxValue, 0)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(int.MinValue, -1, -2147483648)]
        [InlineData(1, int.MaxValue, int.MaxValue)]
        [InlineData(-1, int.MinValue, -2147483648)]
        public void MultiplyBy_IntByInt_ReturnsExpectedResult(int multiplicand, int multiplier, int expectedProduct)
        {
            // Arrange

            // Act
            int actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, short.MaxValue, 0)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(int.MinValue, -1, -2147483648)]
        [InlineData(1, short.MaxValue, short.MaxValue)]
        [InlineData(-1, short.MinValue, 32768)]
        public void MultiplyBy_ShortByInt_ReturnsExpectedResult(int multiplicand, short multiplier, int expectedProduct)
        {
            // Arrange

            // Act
            int actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, long.MaxValue, 0)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(int.MinValue, -1, 2147483648)]
        [InlineData(1, long.MaxValue, long.MaxValue)]
        [InlineData(-1, long.MinValue, -9223372036854775808)]
        public void MultiplyBy_LongByInt_ReturnsExpectedResult(int multiplicand, long multiplier, long expectedProduct)
        {
            // Arrange

            // Act
            long actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, int.MaxValue, 0)]
        [InlineData(short.MaxValue, 1, short.MaxValue)]
        [InlineData(short.MinValue, -1, 32768)]
        [InlineData(1, short.MaxValue, 32767)]
        [InlineData(-1, short.MinValue, 32768)]
        public void MultiplyBy_IntByShort_ReturnsExpectedResult(short multiplicand, int multiplier, int expectedProduct)
        {
            // Arrange

            // Act
            int actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, short.MaxValue, 0)]
        [InlineData(short.MaxValue, 1, short.MaxValue)]
        [InlineData(short.MinValue, -1, 32768)]
        [InlineData(1, short.MaxValue, short.MaxValue)]
        [InlineData(-1, short.MinValue, 32768)]
        public void MultiplyBy_ShortByShort_ReturnsExpectedResult(short multiplicand, short multiplier, int expectedProduct)
        {
            // Arrange

            // Act
            int actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, long.MaxValue, 0)]
        [InlineData(short.MaxValue, 1, short.MaxValue)]
        [InlineData(short.MinValue, -1, 32768)]
        [InlineData(1, long.MaxValue, long.MaxValue)]
        [InlineData(-1, long.MinValue, -9223372036854775808)]
        public void MultiplyBy_LongByShort_ReturnsExpectedResult(short multiplicand, long multiplier, long expectedProduct)
        {
            // Arrange

            // Act
            long actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, int.MaxValue, 0)]
        [InlineData(long.MaxValue, 1, long.MaxValue)]
        [InlineData(long.MinValue, -1, -9223372036854775808)]
        [InlineData(1, int.MaxValue, int.MaxValue)]
        [InlineData(-1, int.MinValue, 2147483648)]
        public void MultiplyBy_IntByLong_ReturnsExpectedResult(long multiplicand, int multiplier, long expectedProduct)
        {
            // Arrange

            // Act
            long actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, short.MaxValue, 0)]
        [InlineData(short.MaxValue, 1, short.MaxValue)]
        [InlineData(short.MinValue, -1, 32768)]
        [InlineData(1, short.MaxValue, short.MaxValue)]
        [InlineData(-1, short.MinValue, 32768)]
        public void MultiplyBy_ShortByLong_ReturnsExpectedResult(long multiplicand, short multiplier, long expectedProduct)
        {
            // Arrange

            // Act
            long actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, -1)]
        [InlineData(1, -2, -2)]
        [InlineData(0, long.MaxValue, 0)]
        [InlineData(short.MaxValue, 1, short.MaxValue)]
        [InlineData(short.MinValue, -1, 32768)]
        [InlineData(1, long.MaxValue, long.MaxValue)]
        [InlineData(-1, long.MinValue, -9223372036854775808)]
        public void MultiplyBy_LongByLong_ReturnsExpectedResult(long multiplicand, long multiplier, long expectedProduct)
        {
            // Arrange

            // Act
            long actualProduct = multiplicand.MultiplyBy(multiplier);

            // Assert
            Assert.Equal(expectedProduct, actualProduct);
        }
    }
}