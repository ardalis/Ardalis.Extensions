namespace Ardalis.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
  /// <summary>
  /// Indicates whether the specified string is null, empty, or consists only of whitespace characters
  /// </summary>
  /// <param name="value">value to check whether null or empty or whitespace.</param>
  /// <returns>True if value is null or empty or whitespace otherwise false.</returns>
  public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
}
