using System;
using System.Text.RegularExpressions;

namespace Ardalis.Extensions.StringManipulation
{
    public static partial class StringManipulationExtensions
    {
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