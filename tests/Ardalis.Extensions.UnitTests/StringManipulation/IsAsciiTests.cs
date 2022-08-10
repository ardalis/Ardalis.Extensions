using Ardalis.Extensions.StringManipulation;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringManipulation;

public class IsAsciiTests
{
  [Theory]
  [InlineData("", true)]
  [InlineData("Hello!\n", true)]
  [InlineData("banana\0\x7F", true)]
  [InlineData("Vi\xe1\xbb\x87t Nam", false)]  
  [InlineData("ประเทศไทย中华Việt Nam", false)]  
  [InlineData("Grüße, Jürgen ❤", false)]
  public void ValidatesIfStringIsAscii(string input, bool expected)
  {
    Assert.Equal(expected, input.IsAscii());
  }
}