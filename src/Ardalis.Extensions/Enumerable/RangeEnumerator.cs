using System;

namespace Ardalis.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
  /// <summary>
  /// Defines an extension method to get a <see cref="RangeEnumerator"/> from a <see cref="Range"/>
  /// that can be used in a foreach loop.
  /// </summary>
  /// <param name="range">Range over which to generate the enumerator</param>
  /// <returns>Enumerator over the given range</returns>
  public static RangeEnumerator GetEnumerator(this Range range) => new(range);

  /// <summary>
  /// Defines an extension method to get a <see cref="RangeEnumerator"/> from an <see cref="int"/>
  /// that can be used in a foreach loop.
  /// </summary>
  /// <param name="number">Ending number in the range</param>
  /// <returns>Enumerator over a range from 0 to <paramref name="number"/></returns>
  public static RangeEnumerator GetEnumerator(this int number) => new(new Range(0, number));

  /// <summary>
  /// Custom enumerator for a <see cref="Range"/> that can be used in a foreach loop.
  /// This type is meant to reduce allocations and act like an <see cref="IEnumerator"/> via duck typing.
  /// </summary>
  public ref struct RangeEnumerator
  {
    private int _current;
    private readonly int _end;

    public RangeEnumerator(Range range)
    {
      if (range.End.IsFromEnd)
      {
        throw new NotSupportedException();
      }

      _current = range.Start.Value - 1;
      _end = range.End.Value;
    }

    public readonly int Current => _current;

    public bool MoveNext()
    {
      // prevent overflow if the end value is int.MaxValue
      if (_current == int.MaxValue)
      {
        return false;
      }

      _current++;
      return _current <= _end;
    }
  }
}
