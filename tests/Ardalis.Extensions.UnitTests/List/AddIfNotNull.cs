using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Extensions.Linq;
using Ardalis.Extensions.List;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Linq;

public class AddIfNotNull
{
  [Fact]
  public void ThrowsGivenNullInput()
  {
    IList<object> list = null;

    Action action = () => list.AddIfNotNull(new object());

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void DoesNothingGivenNullItems()
  {
    var list = new List<string> { "1", "2", "3" };

    list.AddIfNotNull(null);

    Assert.Equal("1", list.First());
    Assert.Equal("3", list.Last());
    Assert.Equal(3, list.Count);
  }

  [Fact]
  public void AddsItemToList()
  {
    var list = new List<int> { 1, 2, 3 };

    list.AddIfNotNull(4);

    Assert.Equal(1, list.First());
    Assert.Equal(4, list.Last());
    Assert.Equal(4, list.Count);
  }
}
