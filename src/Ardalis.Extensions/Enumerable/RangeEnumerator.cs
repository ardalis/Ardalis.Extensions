using System;

namespace Ardalis.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
  public static RangeEnumerator GetEnumerator(this Range range)
  {
    return new RangeEnumerator(range);
  }

  public static RangeEnumerator GetEnumerator(this int number)
  {
    return new RangeEnumerator(new Range(0, number));
  }

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

    public int Current => _current;

    public bool MoveNext()
    {
      _current++;
      return _current < _end;
    }
  }
}
