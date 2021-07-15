using System;
using System.Text.RegularExpressions;

namespace Ardalis.Extensions
{
    public static class StringExtensions
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
        /// Converts string to int.
        /// </summary>
        /// <param name="input">String to truncate.</param>
        /// <returns>Convert to int.</returns>
        public static int ToInt(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return int.Parse(input);
        }

        /// <summary>
        /// Replaces old characters in a string with new characters a certain number of times.
        /// </summary>
        /// <param name="text">String to replace.</param>
        /// <param name="oldString">Old string to be replaced.</param>
        /// <param name="newString">New string to replace the old.</param>
        /// <param name="count">Count of replacements.</param>
        /// <returns>Obtain string with replaced characters.</returns>
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
