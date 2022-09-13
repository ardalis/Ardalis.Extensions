using System;
using System.Collections.Generic;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables;

public class ForEachTests
{
  [Fact]
  public void ThrowsGivenNullInput()
  {
    IEnumerable<object> enumeration = null;

    Action action = () => enumeration.ForEach(x => x.ToString());

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void ThrowsGivenNullAction()
  {
    IEnumerable<object> enumeration = new List<object>();

    Action<object> enumAction = null;

    Action action = () => enumeration.ForEach(enumAction);

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void ExecutesActionOncePerItem()
  {
    IEnumerable<int> input = new List<int> { 1, 2, 3 };
    var sum = 0;
    Action<int> action = (int x) => sum += x;

    input.ForEach(action);

    Assert.Equal(6, sum);
  }

  [Fact]
  public void ForEachPropertyUsingIndex()
  {
    var source = new List<string> { "a", "b", null, "d" };

    var expected = new List<string> { "a0", "b1", "2", "d3" };
    var actual = new List<string>();

    source.ForEach((e, i) => actual.Add($"{e}{i}"));

    Assert.Equal(expected, actual);
  }
}
