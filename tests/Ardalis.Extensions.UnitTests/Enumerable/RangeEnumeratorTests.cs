using System;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables;

public class RangeEnumeratorTests
{
  [Fact]
  public void Foreach_StartIsNegative_ThrowsOutOfRange()
  {
    // implict creation of a Range uses Index which requires a non-negative value
    Assert.Throws<ArgumentOutOfRangeException>(() =>
    {
      foreach (int i in -10..0) { }
    });
  }
  
  [Fact]
  public void Foreach_EndIsNegative_ThrowsOutOfRange()
  {
    // implict creation of a Range uses Index which requires a non-negative value
    Assert.Throws<ArgumentOutOfRangeException>(() =>
    {
      foreach (int i in 0..-1) { }
    });
  }

  [Fact]
  public void Foreach_EndIsFromEnd_ThrowsNotSupported()
  {
    Assert.Throws<NotSupportedException>(() =>
    {
      foreach (int i in 0..^5) { }
    });
  }

  [Fact]
  public void Foreach_EndIsLessThanStart_NoIteration()
  {
    foreach (var i in 5..2)
    {
      // fail if we get here
      Assert.True(false, "A range where the end is less than the start should yield no iterations.");
    }
  }
  
  [Fact]
  public void Foreach_StartEqualsEnd_NoIteration()
  {
    foreach (var i in 0..0)
    {
      Assert.True(false, "A range where the start and end are equal should yield no iterations.");
    }
  }
  
  [Theory]
  [InlineData(0, 10)]
  [InlineData(0, 1000)]
  [InlineData(0, 100000)]
  [InlineData(int.MaxValue - 1, int.MaxValue)]
  public void Foreach_StartToEnd_IteratesAsExpected(int start, int end)
  {
    int counter = start;
    foreach (var i in start..end)
    {
      Assert.Equal(counter, i);
      counter++;
    }
  }
  
  [Theory]
  [InlineData(10)]
  [InlineData(1000)]
  [InlineData(100000)]
  public void Foreach_DotDotToEnd_IteratesAsExpected(int end)
  {
    int counter = 0;
    foreach (var i in ..end)
    {
      Assert.Equal(counter, i);
      counter++;
    }
  }

  [Theory]
  [InlineData(10)]
  [InlineData(1000)]
  [InlineData(100000)]
  public void Foreach_ToEnd_IteratesAsExpected(int end)
  {
    int counter = 0;
    foreach (var i in end)
    {
      Assert.Equal(counter, i);
      counter++;
    }
  }
}
