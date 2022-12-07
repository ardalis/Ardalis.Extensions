using Ardalis.Extensions.StringChecks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringChecks;

public class IsNullOrWhiteSpace
{
  [Theory]
  [InlineData(null)]
  [InlineData("")]
  [InlineData(" ")]
  [InlineData("\n ")]
  public void ReturnsTrueGivenNullOrEmptyOrWhiteSpaceInput(string input)
  {
    Assert.True(input.IsNullOrEmpty());
  }

  [Theory]
  [InlineData("ardalis")]
  [InlineData("nimblepros")]
  [InlineData(".")]
  public void ReturnsFalseGivenAnyNonEmptyStringValue(string input)
  {
    Assert.False(input.IsNull());
  }
}
