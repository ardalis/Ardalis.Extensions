using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Enumerables
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Iterates over an enumerable and executes a function on each item.
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable</typeparam>
        /// <param name="input">An IEnumerable<typeparamref name="T"/> input</param>
        /// <param name="action">The action to invoke on each item in the enumerable</param>
        public static void ForEach<T>(this IEnumerable<T> input, Action<T> action)
        {
            Guard.Against.Null(input, nameof(input));
            Guard.Against.Null(action, nameof(action));

            foreach (var item in input) action(item);
        }

        /// <summary>
        /// Iterates over an enumerable and convert it into csv
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable</typeparam>
        /// <param name="input">An IEnumerable<typeparamref name="T"/></param>
        /// <returns></returns>
        public static string ToCsv<T>(this IEnumerable<T> input)
        {
            StringBuilder csv;
            if(input != null)
            {
                csv = new StringBuilder();
                input.ForEach(i => csv.Append($"{i},"));
                return csv.ToString(0, csv.Length - 1);
            }

            return string.Empty;
        }
    }
}
