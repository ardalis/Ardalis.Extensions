using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.List;

/// <summary>
/// Source: https://github.com/Kritner-Blogs/ExtensionMethods
/// </summary>
public static class ListExtensions
{
  /// <summary>
  /// Adds an <see cref="IEnumerable{T}"/> to an <see cref="IList{T}"/>.
  /// </summary>
  /// <typeparam name="T">The type contained within the <see cref="IList{T}"/>.</typeparam>
  /// <param name="obj">The <see cref="IList{T}"/>.</param>
  /// <param name="items">The items to potentially add.</param>
  /// <exception cref="ArgumentNullException">Thrown if obj is null</exception>
  public static void AddRangeIfNotNull<T>(this IList<T> obj, IEnumerable<T> items)
  {
    Guard.Against.Null(obj, nameof(obj));

    if (items == null) return;

    if (obj is List<T> objList)
    {
      objList.AddRange(items);
      return;
    }

    foreach (var item in items)
    {
      obj.Add(item);
    }
  }
}
