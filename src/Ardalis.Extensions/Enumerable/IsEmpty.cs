using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ardalis.Extensions.Enumerable
{
    public static partial class EnumerableExtensionMethods
    {
        /// <summary>
        /// Checks if a given enumerable is empty. 
        /// </summary>
        /// <typeparam name="T">The generic type of the enumerable.</typeparam>
        /// <param name="input">True if enumerable is empty otherwise false </param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> input) =>
            (input == null)
            ? true
            : false;
    }
}
