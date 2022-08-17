using System.Linq;
using Xunit;
using Ardalis.Extensions.StringManipulation;

namespace Ardalis.Extensions.UnitTests.StringManipulation;

public class LinesTests
{
  [Fact]
  public void SplitStringOnLineEndingLFWithoutFinalLineEnding()
  {
    var data = "\nMäry häd ä little lämb\n\nLittle lämb";
    var lines = data.Lines().Select(line => line.ToString()).ToArray();
    Assert.Equal(new string[] {"", "Märy häd ä little lämb", "", "Little lämb"}, lines);
  }

  [Fact]
  public void SplitStringOnLineEndingCRLFWithoutFinalLineEnding()
  {
    var data = "\r\nMäry häd ä little lämb\r\n\r\nLittle lämb";
    var lines = data.Lines().Select(line => line.ToString()).ToArray();
    Assert.Equal(new string[] {"", "Märy häd ä little lämb", "", "Little lämb"}, lines);
  }

  [Fact]
  public void SplitStringOnLineEndingWithFinalLineEnding()
  {
    var data = "\nMäry häd ä little lämb\n\r\nLittle lämb\n";
    var lines = data.Lines().Select(line => line.ToString()).ToArray();
    Assert.Equal(new string[] {"", "Märy häd ä little lämb", "", "Little lämb"}, lines);
  }
}