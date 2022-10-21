namespace Ardalis.Extensions.StringChecks;

public static partial class StringCheckExtensions
{
  /// <summary>
  /// Checks if a given string is null or not.
  /// Duplicates Ardalis.Extensions.Verification IsNull to avoid need a separate namespace here
  /// </summary>
  /// <param name="value">value to check whether null or not.</param>
  /// <returns>True if value is null otherwise false.</returns>
  public static bool IsNull(this string value) =>
       (value == null) ? true : false;

}
