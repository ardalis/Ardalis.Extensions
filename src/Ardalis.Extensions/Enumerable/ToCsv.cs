using System.Collections.Generic;
using System.Text;

namespace Ardalis.Extensions.Enumerable
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Iterates over an enumerable and convert it into csv
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable</typeparam>
        /// <param name="input">An IEnumerable<typeparamref name="T"/></param>
        /// <returns></returns>
        public static string ToCsv<T>(this IEnumerable<T> input)
        {
            if (input == null)
            {
                return string.Empty;
            }
                        
            StringBuilder csvBuilder = new StringBuilder();

            input.ForEach(i => csvBuilder.Append($"{i},"));

            return csvBuilder.ToString(0, csvBuilder.Length - 1);
        }
    }
}