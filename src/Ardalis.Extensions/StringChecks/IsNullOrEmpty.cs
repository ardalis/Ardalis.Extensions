namespace Ardalis.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
  /// <summary>
  /// Indicates whether the specified string is null or string.Empty
  /// </summary>
  /// <param name="value">value to check whether null or empty or neither.</param>
  /// <returns>True if value is null or empty otherwise false.</returns>
  public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
}
