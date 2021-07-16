using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

        /// <summary>
        /// Reverses the input <see cref="string"/>.
        /// </summary>
        /// <param name="input">The input <see cref="string"/> to be reversed.</param>
        /// <returns>Reversed <see cref="string"/>.</returns>
        public static string Reverse(this string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            if (input.Length == 1) return input;

            // Tradeoff: we can check whether the input is a palindrome (= same when reversed)
            // to avoid extra allocation, but for the cost of extra time spent checking.
            // Since most strings are not expected to be palindromes, we are simply not doing checking

            // Alternative designs:
            // 1. Get input char array (String.ToCharArray), reverse it (Array.Reverse) and use it in string ctor
            // 2. Use StringBuilder and add characters in reverse order

            string reversed = new string(' ', input.Length);

            ref char target = ref MemoryMarshal.GetReference(reversed.AsSpan());
            ref char targetEnd = ref Unsafe.Add(ref target, reversed.Length);

            ref char source = ref MemoryMarshal.GetReference(input.AsSpan());
            source = ref Unsafe.Add(ref source, input.Length - 1); // Set source to the last character

            do
            {
                target = source;

                target = ref Unsafe.Add(ref target, 1);
                source = ref Unsafe.Add(ref source, -1);
            }
            while (Unsafe.IsAddressLessThan(ref target, ref targetEnd));

            return reversed;
        }
    }
}