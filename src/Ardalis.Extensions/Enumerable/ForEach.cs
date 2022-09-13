using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
  /// <summary>
  /// Iterates over an enumerable and executes an Action on each element.
  /// </summary>
  /// <typeparam name="TSource">The type of the elements of source.</typeparam>
  /// <param name="source">A sequence of values to invoke an action on.</param>
  /// <param name="action">An Action to invoke on each source element.</param>
  public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
  {
    Guard.Against.Null(source, nameof(source));
    Guard.Against.Null(action, nameof(action));

    foreach (var item in source)
    {
      action(item);
    }
  }

  /// <summary>
  /// Iterates over an enumerable and executes an Action on each element.
  /// </summary>
  /// <typeparam name="TSource">The type of the elements of source.</typeparam>
  /// <param name="source">A sequence of values to invoke an action on.</param>
  /// <param name="callback">
  ///  An Action to invoke on each source element.
  ///  The second parameter of the Action represents the index of the source element.
  /// </param>
  public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource, int> action)
  {
    Guard.Against.Null(source, nameof(source));
    Guard.Against.Null(action, nameof(action));

    int index = 0;
    foreach (var item in source)
    {
      action(item, index++);
    }
  }
}
