using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Extensions.Linq;
using Ardalis.Extensions.List;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Linq;

public class AddRangeIfNotNull
{
  [Fact]
  public void ThrowsGivenNullInput()
  {
    IList<object> list = null;

    Action action = () => list.AddRangeIfNotNull(new List<object>());

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void DoesNothingGivenNullItems()
  {
    var list = new List<int> { 1, 2, 3 };

    list.AddRangeIfNotNull(null);

    Assert.Equal(1, list.First());
    Assert.Equal(3, list.Last());
    Assert.Equal(3, list.Count);
  }

  [Fact]
  public void DoesNothingGivenEmptyListOfItems()
  {
    var list = new List<int> { 1, 2, 3 };

    list.AddRangeIfNotNull(new List<int>());

    Assert.Equal(1, list.First());
    Assert.Equal(3, list.Last());
    Assert.Equal(3, list.Count);
  }

  [Fact]
  public void AddsItemsToList()
  {
    var list = new List<int> { 1, 2, 3 };

    list.AddRangeIfNotNull(new List<int>() { 4, 5 });


    Assert.Equal(1, list.First());
    Assert.Equal(5, list.Last());
    Assert.Equal(5, list.Count);
  }
}
