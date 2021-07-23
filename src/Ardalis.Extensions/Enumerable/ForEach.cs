using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;

namespace Ardalis.Extensions.Enumerable
{
    public static partial class EnumerableExtensionMethods
    {
        /// <summary>
        /// Iterates over an enumerable and executes an Action on each item.
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable</typeparam>
        /// <param name="input">An IEnumerable<typeparamref name="T"/> input</param>
        /// <param name="action">The action to invoke on each item in the enumerable</param>
        public static void ForEach<T>(this IEnumerable<T> input, Action<T> action)
        {
            Guard.Against.Null(input, nameof(input));
            Guard.Against.Null(action, nameof(action));

            foreach (var item in input)
            {
                action(item);
            }
        }
    }
}