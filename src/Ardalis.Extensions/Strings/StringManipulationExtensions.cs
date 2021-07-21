using System;
using System.Text.RegularExpressions;

namespace Ardalis.Extensions.Strings
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

        /// <summary>
        /// Replaces old characters in a string with new characters a certain number of times.
        /// </summary>
        /// <param name="text">String to replace.</param>
        /// <param name="oldString">Old string to be replaced.</param>
        /// <param name="newString">New string to replace the old.</param>
        /// <param name="count">Count of replacements.</param>
        /// <returns>Obtain string with replaced characters.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the count is a negative number.</exception>
        /// <exception cref="ArgumentException">Thrown when the oldString or newString is null.</exception>
        public static string ReplaceString(this string text, string oldString, string newString, int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count can not be negative");
            }
            else if (oldString is null)
            {
                throw new ArgumentException(nameof(oldString), "OldString can not be null");
            }
            else if (newString is null)
            {
                throw new ArgumentException(nameof(newString), "NewString can not be null");
            }

            Regex regex = new Regex(Regex.Escape(oldString));

            return regex.Replace(text, newString, count);
        }
    }
}