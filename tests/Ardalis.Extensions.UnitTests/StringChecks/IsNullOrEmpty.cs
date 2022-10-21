using Ardalis.Extensions.StringChecks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringChecks;

public class IsNullOrEmpty
{
  [Theory]
  [InlineData(null)]
  [InlineData("")]
  public void ReturnsTrueGivenNullOrEmptyInput(string input)
  {
    Assert.True(input.IsNullOrEmpty());
  }

  [Theory]
  [InlineData("ardalis")]
  [InlineData(" ")]
  public void ReturnsFalseGivenAnyNonEmptyStringValue(string input)
  {
    Assert.False(input.IsNull());
  }
}
