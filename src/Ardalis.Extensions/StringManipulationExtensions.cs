using System;

namespace Ardalis.Extensions
{
    public static class StringManipulationExtensions
    {
        /// <summary>
        /// Truncates string so that it is no longer than the specified number of characters. 
        /// 
        /// Source: https://stackoverflow.com/a/17249604/13729
        /// </summary>
        /// <param name="input">String to truncate.</param>
        /// <param name="length">Maximum string length.</param>
        /// <returns>Original string or a truncated one if the original was too long.</returns>
        public static string Truncate(this string input, int length)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be >= 0");
            }

            int maxLength = Math.Min(input.Length, length);
            return input.Substring(0, maxLength);
        }

        /// <summary>
        /// Returns the rightmost N characters where length is N.
        /// Returns the full string if it is less than N characters long.
        /// Behaves similarly to C#8 "foo"[^N..] syntax but is more forgiving.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Right(this string input, int length)
        {
            if(String.IsNullOrEmpty(input)) return string.Empty;
            if(input.Length <= length) return input;

            return input.Substring(input.Length - length);
        }

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