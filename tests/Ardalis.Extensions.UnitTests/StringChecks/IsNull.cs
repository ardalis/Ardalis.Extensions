using Ardalis.Extensions.StringChecks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.StringChecks;

public class IsNull
{
  [Fact]
  public void ReturnsTrueGivenNullInput()
  {
    string input = null;
    Assert.True(input.IsNull());
  }

  [Theory]
  [InlineData("ardalis")]
  [InlineData("")]
  [InlineData(" ")]
  public void ReturnsFalseGivenAnyStringValue(string input)
  {
    Assert.False(input.IsNull());
  }
}
