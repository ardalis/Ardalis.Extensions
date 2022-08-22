using System;
using Xunit;
using Ardalis.Extensions.StringManipulation;

namespace Ardalis.Extensions.UnitTests.StringManipulation;

public class RepeatTests
{
  [Fact]
  public void ShouldReturnEmptyStringWhenRepeatingAnEmptyString()
  {
    Assert.Equal("", "".Repeat(3));
  }

  [Fact]
  public void ShouldReturnEmptyStringWhenRepeatingZeroTimes()
  {
    Assert.Equal("", "abc".Repeat(0));
  }

  [Fact]
  public void ShouldThrowExceptionWhenOverflow()
  {
    Assert.ThrowsAny<OutOfMemoryException>(() => "abc".Repeat(int.MaxValue));
  }

  [Theory]
  [InlineData("a", 3, "aaa")]
  [InlineData("abc", 3, "abcabcabc")]
  public void ShouldRepeatStrings(string input, uint n, string expected)
  {
    Assert.Equal(expected, input.Repeat(n));
  }
}