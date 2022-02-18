using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Linq;

public static partial class LinqExtensions
{
  /// <summary>
  /// Distinct iterator 
  /// </summary>
  /// <typeparam name="TSource">The generic type of IEnumerable<typeparamref name="TSource"/></typeparam>
  /// <typeparam name="TKey">Key for the selection</typeparam>
  /// <param name="source">The source iterator</param>
  /// <param name="selector">The selector function for distinction</param>
  /// <exception cref="System.ArgumentNullException">Throw if the source iterator or the selector function are null.</exception>
  /// <returns>Returns the distincted iterator.</returns>
  /// 

  /// This already exists in LINQ in .NET 6
  /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinctby?view=net-6.0
  /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/set-operations?branch=main#distinct-and-distinctby

  //public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
  //    this IEnumerable<TSource> source,
  //    Func<TSource, TKey> selector)
  //{
  //  Guard.Against.Null(source, nameof(source));
  //  Guard.Against.Null(selector, nameof(selector));

  //  return source.GroupBy(selector)
  //      .Select(x => x.First());
  //}
}
