using System;
using Ardalis.Extensions.StringManipulation;
using Xunit;

namespace Ardalis.Extensions.UnitTests;

public class ReverseTests
{
  [Theory]
  [InlineData(null)]
  [InlineData("")]
  public void ReturnsEmptyStringGivenNullOrEmptyString(string input)
  {
    string result = input.Reverse();

    Assert.Equal(String.Empty, result);
  }

  [Theory]
  [InlineData("a", "a")]
  [InlineData("abcde", "edcba")]
  public void ReturnsReversedString(string input, string expectedResult)
  {
    string result = input.Reverse();

    Assert.Equal(expectedResult, result);
  }
}
