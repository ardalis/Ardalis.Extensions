namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  /// <summary>
  /// Returns the rightmost N characters where length is N.
  /// Returns the full string if it is less than N characters long.
  /// Behaves similarly to C#8 "foo"[^N..] syntax but is more forgiving.
  /// </summary>
  /// <param name="input"></param>
  /// <param name="length"></param>
  /// <returns></returns>
  public static string Right(this string input, int length)
  {
    if (string.IsNullOrEmpty(input))
    {
      return string.Empty;
    }

    if (input.Length <= length)
    {
      return input;
    }

    return input.Substring(input.Length - length);
  }
}
