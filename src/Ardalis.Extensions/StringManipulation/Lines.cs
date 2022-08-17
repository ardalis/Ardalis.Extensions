using System;
using System.Collections.Generic;
using System.Linq;

namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  /// <summary>
  /// An iterator over the lines of a string, as string slices represented by a <see cref="ReadonlyMemory{char}"/>.
  /// Lines are ended with either a newline (\n) or a carriage return with a line feed (\r\n).
  /// The final line ending is optional. A string that ends with a final line ending will return the same lines as an otherwise identical string without a final line ending.
  /// </summary>
  /// <example>
  /// <code>
  /// var text = "foo\r\nbar\n\nbaz";
  /// var lines = text.Lines().GetEnumerator();
  /// lines.MoveNext();
  /// Assert.Equal("foo", lines.Current.ToString());
  /// lines.MoveNext();
  /// Assert.Equal("bar", lines.Current.ToString());
  /// lines.MoveNext();
  /// Assert.Equal("", lines.Current.ToString());
  /// lines.MoveNext();
  /// Assert.Equal("baz", lines.Current.ToString());
  /// lines.MoveNext();
  /// Assert.False(lines.MoveNext());
  /// </code>
  /// </example>
  public static IEnumerable<ReadOnlyMemory<char>> Lines(this string text)
  {
    var textMemory = text.AsMemory();
    var lineStartIndex = 0;
    var currentIndex = 0;

    while (currentIndex < text.Length)
    {
      if (text[currentIndex] == '\n')
      {
        yield return textMemory.Slice(lineStartIndex, currentIndex - lineStartIndex);
        lineStartIndex = currentIndex + 1;
        currentIndex++;
        continue;
      }

      if (text[currentIndex] == '\r')
      {
        if (currentIndex + 1 < text.Length && text[currentIndex + 1] == '\n')
        {
          yield return textMemory.Slice(lineStartIndex, currentIndex - lineStartIndex);
          lineStartIndex = currentIndex + 2;
          currentIndex += 2;
          continue;
        }
      }

      if (currentIndex == text.Length - 1)
      {
        yield return textMemory.Slice(lineStartIndex);
      }

      currentIndex++;
    }
  }
}