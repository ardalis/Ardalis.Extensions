using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Linq;

public static partial class LinqExtensions
{

  /// <summary>
  /// Iterates over an enumerable and executes a function on each item.
  /// </summary>
  /// <typeparam name="T">The generic type of the enumerable</typeparam>
  /// <param name="input">An IEnumerable<typeparamref name="T"/> input</param>
  /// <param name="func">The function to invoke on each item in the enumerable</param>
  /// <returns>An IEnumerable<T> that contains elements from the input sequence that have been acted on.</returns>
  public static IEnumerable<T> Perform<T>(this IEnumerable<T> input, Func<T, T> func)
  {
    Guard.Against.Null(input, nameof(input));
    Guard.Against.Null(func, nameof(func));

    foreach (var item in input)
    {
      yield return func(item);
    }
  }
}
