using System;
using System.Text.Json;

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
        /// Converts JSON string to the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T FromJsonString<T>(this string t)
        {
            var value = JsonSerializer.Deserialize<T>(t);

            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Converts a Type to a JSON string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ToJsonString<T>(this T t)
        {
            var value = JsonSerializer.Serialize(t);

            return value;
        }
    }
}
