using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Linq;

// These tests now target the built-in LINQ DistinctBy extension, not an extension in this package.
// This extension was added in .NET 5 and has been removed from this package
// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinctby?view=net-6.0&viewFallbackFrom=net-5.0
public record User(string Name);

public class DistinctByTest
{
  [Fact]
  public void ConcatSequenceInRightOrder()
  {
    // Arrange
    IEnumerable<User> iterator = new[] { new User("name-test"), new User("name-test"), new User("name-test") };

    IEnumerable<User> expectedIterator = new[] { new User("name-test") };

    // Act
    var distincedIterator = iterator.DistinctBy(x => x.Name)
        .ToList();

    // Assert
    Assert.Single(distincedIterator);
    Assert.Equal(expectedIterator, distincedIterator);
  }

  [Fact]
  public void ThrowsArgumentNullException_OnBaseIterator()
  {
    // Arrange
    IEnumerable<User> baseIterator = null;

    // Act
    Action action = () => baseIterator.DistinctBy(x => x.Name);

    // Assert
    Assert.Throws<ArgumentNullException>(action);
  }

  [Fact]
  public void ThrowsArgumentNullException_OnConcatIterators()
  {
    // Arrange
    IEnumerable<User> baseIterator = new[] { new User("name-test") };

    // Act
    Action action = () => baseIterator.DistinctBy<User, string>(null);

    // Assert
    Assert.Throws<ArgumentNullException>(action);
  }
}
