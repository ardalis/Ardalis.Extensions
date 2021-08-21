namespace Ardalis.Extensions.UnitTests.Math
{
    using Xunit;
    using Ardalis.Extensions.Math;

    public class AddTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, int.MaxValue, int.MaxValue)]
        [InlineData(int.MaxValue, 1, int.MinValue)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        [InlineData(1, int.MaxValue, int.MinValue)]
        [InlineData(-1, int.MinValue, int.MaxValue)]
        public void Add_IntToInt_ReturnsExpectedResult(int augend, int addend, int expectedSum)
        {
            // Arrange

            // Act
            int actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, short.MaxValue, short.MaxValue)]
        [InlineData(int.MaxValue, 1, int.MinValue)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Add_ShortToInt_ReturnsExpectedResult(int augend, short addend, int expectedSum)
        {
            // Arrange

            // Act
            int actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, long.MaxValue, long.MaxValue)]
        [InlineData(int.MaxValue, 1, 2147483648)]
        [InlineData(int.MinValue, -1, -2147483649)]
        [InlineData(1, long.MaxValue, long.MinValue)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Add_LongToInt_ReturnsExpectedResult(int augend, long addend, long expectedSum)
        {
            // Arrange

            // Act
            long actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, int.MaxValue, int.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Add_IntToShort_ReturnsExpectedResult(short augend, int addend, int expectedSum)
        {
            // Arrange

            // Act
            int actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, short.MaxValue, short.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Add_ShortToShort_ReturnsExpectedResult(short augend, short addend, int expectedSum)
        {
            // Arrange

            // Act
            int actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, long.MaxValue, long.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, long.MaxValue, long.MinValue)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Add_LongToShort_ReturnsExpectedResult(short augend, long addend, long expectedSum)
        {
            // Arrange

            // Act
            long actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }



        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, int.MaxValue, int.MaxValue)]
        [InlineData(long.MaxValue, 1, long.MinValue)]
        [InlineData(long.MinValue, -1, long.MaxValue)]
        [InlineData(1, int.MaxValue, 2147483648)]
        [InlineData(-1, int.MinValue, -2147483649)]
        public void Add_IntToLong_ReturnsExpectedResult(long augend, int addend, long expectedSum)
        {
            // Arrange

            // Act
            long actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, short.MaxValue, short.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, short.MaxValue, 32768)]
        [InlineData(-1, short.MinValue, -32769)]
        public void Add_ShortToLong_ReturnsExpectedResult(long augend, short addend, long expectedSum)
        {
            // Arrange

            // Act
            long actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, -1, 0)]
        [InlineData(1, -2, -1)]
        [InlineData(0, long.MaxValue, long.MaxValue)]
        [InlineData(short.MaxValue, 1, 32768)]
        [InlineData(short.MinValue, -1, -32769)]
        [InlineData(1, long.MaxValue, long.MinValue)]
        [InlineData(-1, long.MinValue, long.MaxValue)]
        public void Add_LongToLong_ReturnsExpectedResult(long augend, long addend, long expectedSum)
        {
            // Arrange

            // Act
            long actualSum = augend.Add(addend);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}