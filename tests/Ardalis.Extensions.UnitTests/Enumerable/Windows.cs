using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables;

public class WindowsTests
{
  [Fact]
  public void ThrowsGivenNullInput()
  {
    IEnumerable<object> enumeration = null;

    IEnumerable<object> action() => enumeration.Windows(4).ToList();

    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void ThrowsGivenNegativeWindowSize()
  {
    IEnumerable<object> enumeration = new List<object>();

    IEnumerable<object> action() => enumeration.Windows(-1).ToList();

    Assert.Throws<ArgumentException>(action);
  }

  [Fact]
  public void ThrowsGivenZeroWindowSize()
  {
    IEnumerable<object> enumeration = new List<object>();

    IEnumerable<object> action() => enumeration.Windows(0).ToList();

    Assert.Throws<ArgumentException>(action);
  }

  [Fact]
  public void IteratesThroughWindowsOfGivenSize()
  {
    IEnumerator<char[]> windows = "rust".Windows(2).GetEnumerator();

    windows.MoveNext();
    Assert.Equal(new[] { 'r', 'u' }, windows.Current);
    windows.MoveNext();
    Assert.Equal(new[] { 'u', 's' }, windows.Current);
    windows.MoveNext();
    Assert.Equal(new[] { 's', 't' }, windows.Current);
    Assert.False(windows.MoveNext());
  }

  [Fact]
  public void BehavesLikeAnEmptyCollectionWhenWindowSizeIsGreaterThanSource()
  {
    IEnumerator<char[]> windows = "foo".Windows(4).GetEnumerator();
    Assert.False(windows.MoveNext());
  }
}
