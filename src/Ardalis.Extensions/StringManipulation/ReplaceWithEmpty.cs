using System;

namespace Ardalis.Extensions.StringManipulation
{
    public static partial class StringManipulationExtensions
    {
        /// <summary>
        /// Replaces all instances of a string in an input string with String.Empty.
        /// </summary>
        /// <param name="input">The string to modify.</param>
        /// <param name="subStringToRemove">The string to remove/replace.</param>
        /// <returns></returns>
        public static string ReplaceWithEmpty(this string input, string subStringToRemove)
        {
            return input.Replace(subStringToRemove, String.Empty);
        }
    }
}