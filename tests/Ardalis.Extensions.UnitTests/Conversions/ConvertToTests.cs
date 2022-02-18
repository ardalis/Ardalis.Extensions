using System;
using Ardalis.Extensions.Conversions;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Conversions;

public class ConvertToTests
{
  [Fact]
  public void ReturnsInt4WhenDecimal4IsProvided()
  {
    // Arrange
    decimal sut = 4.0m;

    // Act
    int actual = sut.ConvertTo<decimal, int>();

    // Assert
    Assert.Equal(4, actual);
  }

  [Fact]
  public void ReturnsDecimal4WhenInt4IsProvided()
  {
    // Arrange
    int sut = 4;

    // Act
    decimal actual = sut.ConvertTo<int, decimal>();

    // Assert
    Assert.Equal(4.0m, actual);
  }

  [Fact]
  public void ThrowsInvalidCastExceptionWhenDouble4IsConvertedToDayOfWeek()
  {
    // Arrange
    double sut = 4;

    // Act
    Action action = () => sut.ConvertTo<double, DayOfWeek>();


    // Assert
    Assert.Throws<InvalidCastException>(action);
  }

  [Fact]
  public void ThrowsInvalidCastExceptionWhenLongMaxIsConvertedToInt()
  {
    // Arrange
    long sut = long.MaxValue;

    // Act
    Action action = () => sut.ConvertTo<long, int>();


    // Assert
    Assert.Throws<OverflowException>(action);
  }
}
