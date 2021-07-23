using System;
using System.Collections.Generic;

namespace Ardalis.Extensions.Linq
{
    public static partial class LinqExtensionMethods
    {
        public static IEnumerable<T> Perform<T>(this IEnumerable<T> source, Func<T,T> func)
        {

        }
    }
}