using System.Collections.Generic;
using System.Linq;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Linq;

public static partial class LinqExtensions
{

  /// <summary>
  /// Combines the given base iterator with all iterators in param parameter
  /// </summary>
  /// <typeparam name="TSource">The generic type of IEnumerable<typeparamref name="TSource"/></typeparam>
  /// <param name="baseIterator">Base Iterator of IEnumerable<typeparamref name="TSource"/></param>
  /// <param name="iterators">Iterators to be concatenated of IEnumerable<typeparamref name="TSource"/> Array</param>
  /// <exception cref="System.ArgumentNullException">Throw if the baseIterator or the iterators to be concatenated are null.</exception>
  /// <returns>Returns concatinated iterator.</returns>
  public static IEnumerable<TSource> ConcatMany<TSource>(
      this IEnumerable<TSource> baseIterator,
      params IEnumerable<TSource>[] iterators)
  {
    Guard.Against.Null(baseIterator, nameof(baseIterator));
    Guard.Against.Null(iterators, nameof(iterators));

    var combined = iterators.Aggregate(
        (IEnumerable<TSource> acc, IEnumerable<TSource> curr) => acc.Concat(curr));

    return baseIterator.Concat(combined);
  }
}
