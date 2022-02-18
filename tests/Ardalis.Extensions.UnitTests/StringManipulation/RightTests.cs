using System;
using Ardalis.Extensions.StringManipulation;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringManipulation;

public class RightTests
{
  [Theory]
  [InlineData(null)]
  [InlineData("")]
  public void ReturnsEmptyStringGivenNullOrEmptyString(string input)
  {
    var result = input.Right(2);

    Assert.Equal(string.Empty, result);
  }

  [Theory]
  [InlineData("a")]
  [InlineData("aa")]
  [InlineData("aaa")]
  [InlineData("aaaa")]
  [InlineData("aaaaa")]
  public void ReturnsGivenStringIfInputLengthLessEqualProvidedLength(string input)
  {
    int lengthOfStringToRetrun = 5;

    var result = input.Right(lengthOfStringToRetrun);

    Assert.Equal(input, result);
  }

  [Theory]
  [InlineData("1234567890")]
  [InlineData("234567890")]
  [InlineData("34567890")]
  [InlineData("4567890")]
  [InlineData("567890")]
  public void ReturnsLast5CharactersGivenLength5AndLongerString(string input)
  {
    int lengthOfStringToRetrun = 5;

    var result = input.Right(lengthOfStringToRetrun);

    Assert.Equal("67890", result);
  }

  [Theory]
  [InlineData("1234567890")]
  [InlineData("234567890")]
  [InlineData("34567890")]
  [InlineData("4567890")]
  [InlineData("567890")]
  [InlineData("aaaaa")]
  // The following all throw exceptions using C#8 syntax
  //[InlineData("")]
  //[InlineData("a")]
  //[InlineData("aa")]
  //[InlineData("aaa")]
  //[InlineData("aaaa")]
  //[InlineData(null)]
  public void ReturnsCSharp8Version(string input)
  {
    Assert.Equal(input[^5..], input.Right(5));
  }
}
