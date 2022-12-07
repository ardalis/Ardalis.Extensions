using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
  /// <summary>
  /// Returns an IEnumerable over all contiguous windows of length size. 
  /// The windows overlap. If the source is shorter than size, the IEnumerable returns no values.
  /// </summary>
  /// <throws cref="ArgumentException">
  /// This method will throw if size is 0 or negative.
  /// </throws>
  /// <example>
  /// <code>
  /// var windows = "rust".Windows(2).GetEnumerator();
  ///
  /// windows.MoveNext();
  /// Assert.Equal(new [] { 'r', 'u' }, windows.Current);
  /// windows.MoveNext();
  /// Assert.Equal(new [] { 'u', 's' }, windows.Current);
  /// windows.MoveNext();
  /// Assert.Equal(new [] { 's', 't' }, windows.Current);
  /// Assert.False(windows.MoveNext());
  /// </code>
  /// </example>
  public static IEnumerable<T[]> Windows<T>(this IEnumerable<T> source, int size)
  {
    Guard.Against.Null(source, nameof(source));
    Guard.Against.NegativeOrZero(size, nameof(size));

    var enumerator = source.GetEnumerator();
    Queue<T> window = new(size + 1);
    while (enumerator.MoveNext())
    {
      window.Enqueue(enumerator.Current);
      if (window.Count > size) window.Dequeue();
      if (window.Count == size) yield return window.ToArray();
    }
  }
}
