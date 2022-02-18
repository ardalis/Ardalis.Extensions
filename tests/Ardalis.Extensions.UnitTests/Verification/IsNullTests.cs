using Ardalis.Extensions.Verification;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Verification;

public class IsNullTests
{
  [Theory]
  [InlineData(null)]
  public void ReturnsTrueGivenNull(object value)
  {
    var result = value.IsNull();

    Assert.True(result);
  }

  [Theory]
  [InlineData("text")]
  [InlineData(45)]
  [InlineData(true)]
  public void ReturnsFalseGivenValue(object value)
  {
    var result = value.IsNull();

    Assert.False(result);
  }
}
