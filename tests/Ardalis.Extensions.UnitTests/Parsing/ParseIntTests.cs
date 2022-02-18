using System;
using Ardalis.Extensions.Parsing;
using Xunit;

namespace Ardalis.Extensions.UnitTests;

public class ParseIntTests
{
  [Fact]
  public void ThrowsExceptionGivenNullInput()
  {
    string input = null;
    Action action = () => input.ParseInt();

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void ThrowsExceptionGivenEmptyInput()
  {
    string input = "";
    Action action = () => input.ParseInt();

    Assert.Throws<FormatException>(action);
  }

  [Fact]
  public void ThrowsExceptionGivenInputTooBig()
  {
    string input = "9999999999999999999999999999999999999";
    Action action = () => input.ParseInt();

    Assert.Throws<OverflowException>(action);
  }

  [Fact]
  public void ThrowsExceptionGivenInputTooSmall()
  {
    string input = "-9999999999999999999999999999999999999";
    Action action = () => input.ParseInt();

    Assert.Throws<OverflowException>(action);
  }
}
