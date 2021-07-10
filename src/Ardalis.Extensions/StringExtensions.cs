using System;

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
        /// <param name="input">String to int.</param>
        /// <returns>int.</returns>
        public static int ToInt(this string input)
        {
            int.TryParse(input, out var result);

            return result;
        }

        /// <summary>
        /// Converts string to nullable int.
        /// If cannot convert to int then return null.
        /// </summary>
        /// <param name="input">String to nullable int.</param>
        /// <returns>nullable int.</returns>
        public static int? ToMaybeInt(this string input)
        {
            if (!int.TryParse(input, out var result))
            {
                return null;
            }

            return result;
        }
    }
}
