using System;
using System.Linq;
using System.Collections.Generic;

using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Linq
{
    public static partial class LinqExtensions
    {
        /// <summary>
        /// Distinct iterator 
        /// </summary>
        /// <typeparam name="TSource">The generic type of IEnumerable<typeparamref name="TSource"/></typeparam>
        /// <typeparam name="TKey">Key for the selection</typeparam>
        /// <param name="source">The source iterator</param>
        /// <param name="selector">The selector function for dinsticion</param>
        /// <exception cref="System.ArgumentNullException">Throw if the source iterator or the selctor function are null.</exception>
        /// <returns>Returns the distincted iterator.</returns>
        /// 
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> selector)
        {
            Guard.Against.Null(source, nameof(source));
            Guard.Against.Null(selector, nameof(selector));

            return source.GroupBy(selector)
                .Select(x => x.First());
        }
    }
}
