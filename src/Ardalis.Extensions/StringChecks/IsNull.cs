namespace Ardalis.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
  /// <summary>
  /// Checks if a given string is null or not.
  /// Duplicates Ardalis.Extensions.Verification IsNull to avoid needing a separate namespace here
  /// </summary>
  /// <param name="value">value to check whether null or not.</param>
  /// <returns>True if value is null otherwise false.</returns>
  public static bool IsNull(this string value) => value is null;
}
