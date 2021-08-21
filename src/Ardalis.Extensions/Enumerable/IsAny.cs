using System.Collections.Generic;
using System.Linq;

namespace Ardalis.Extensions.Enumerable
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Checks if a given enumerable is not empty. 
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable.</typeparam>
        /// <param name="input">An IEnumerable<typeparamref name="T"/></param>
        /// <returns>True if enumerable have at least one value otherwise false.</returns>
        public static bool IsAny<T>(this IEnumerable<T> input) =>
            input != null && input.Any();
    }

}
