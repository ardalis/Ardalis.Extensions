using System;

namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  /// <summary>
  /// Reverses the input <see cref="string"/>.
  /// </summary>
  /// <param name="input">The input <see cref="string"/> to be reversed.</param>
  /// <returns>Reversed <see cref="string"/>.</returns>
  public static string Reverse(this string input)
  {
    if (string.IsNullOrEmpty(input)) return String.Empty;
    if (input.Length == 1) return input;

    Span<char> result = input.Length > 1024 ? input.ToCharArray() : stackalloc char[input.Length];
    if (input.Length <= 1024)
    {
      input.AsSpan().CopyTo(result);
    }
    result.Reverse();

    return result.ToString();
  }
}
