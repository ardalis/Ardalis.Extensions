using System;
using System.Text;

namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  /// <summary>
  /// Creates a new <see cref="String"/> by repeating n times.
  /// </summary>
  /// <throws cref="OutOfMemoryException">
  /// This method will throw if the capacity would overflow.
  /// </throws>
  /// <example>
  /// Basic usage:
  /// <code>
  /// Assert.Equal("abcabcabcabc", "abc".Repeat(4));
  /// </code>
  /// </example>
  /// <example>
  /// Throws upon overflow:
  /// <code>
  /// // this will throw at runtime
  /// var huge = "0123456789".Repeat(int.MaxValue);
  /// </code>
  /// </example>
  public static string Repeat(this string text, uint n)
  {
    return new StringBuilder(text.Length * (int)n).Insert(0, text, (int)n).ToString();
  }
}
