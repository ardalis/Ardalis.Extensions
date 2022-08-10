using System;
using System.Linq;

namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  /// <summary>
  /// Checks if all characters in this string are within the ASCII range.
  /// </summary>
  /// <example>
  /// <code>
  /// var ascii = "hello!\n";
  /// var nonAscii = "Grüße, Jürgen ❤";
  /// 
  /// Assert.True(ascii.IsAscii());
  /// Assert.False(nonAscii.IsAscii());
  /// </code>
  /// </example>
  public static bool IsAscii(this string text)
  {
    return text.ToCharArray().All(c => IsAscii(c));
  }


  // Return true for all characters below or equal U+007f, which is ASCII.
 
  /// <summary>
  /// Returns <see langword="true"/> if <paramref name="c"/> is an ASCII
  /// character ([ U+0000..U+007F ]).
  /// </summary>
  /// <remarks>
  /// Per http://www.unicode.org/glossary/#ASCII, ASCII is only U+0000..U+007F.
  /// </remarks>
  private static bool IsAscii(char c) => (uint)c <= '\x007F';
}
