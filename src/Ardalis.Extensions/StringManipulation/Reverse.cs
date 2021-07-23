using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ardalis.Extensions.StringManipulation
{
    public static partial class StringManipulationExtensions
    {
        /// <summary>
        /// Reverses the input <see cref="string"/>.
        /// </summary>
        /// <param name="input">The input <see cref="string"/> to be reversed.</param>
        /// <returns>Reversed <see cref="string"/>.</returns>
        public static string Reverse(this string input)
        {
            if (string.IsNullOrEmpty(input)) return String.Empty;
            if (input.Length == 1) return input;

            // Tradeoff: we can check whether the input is a palindrome (= same when reversed)
            // to avoid extra allocation, but for the cost of extra time spent checking.
            // Since most strings are not expected to be palindromes, we are simply not checking

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