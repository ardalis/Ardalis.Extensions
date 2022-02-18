using System;
using System.Text.Json;

namespace Ardalis.Extensions.Serialization.Json;

public static partial class JsonExtensions
{
  /// <summary>
  /// Converts JSON string to the specified type
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="t"></param>
  /// <returns></returns>
  public static T FromJson<T>(this string t)
  {
    T value = JsonSerializer.Deserialize<T>(t);

    return (T)Convert.ChangeType(value, typeof(T));
  }
}
