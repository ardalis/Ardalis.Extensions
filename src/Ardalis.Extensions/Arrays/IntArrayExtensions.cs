using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ardalis.Extensions.Arrays
{
    public static class IntArrayExtensions
    {
        /// <summary>
        /// Gets odd numbers from a given array
        /// </summary>
        /// <param name="input">An array of type int</param>
        /// <returns>Odd numbers if an input have odd numbers otherwise should returns an empty array</returns>
        public static int[] OddNumbers(this int[] input) =>
            (input.Length != 0)
            ? input.Where(i => (i % 2) != 0).OrderBy(i => i).ToArray()
            : input;
            


        /// <summary>
        /// Gets even numbers from a given array
        /// </summary>
        /// <param name="input">An array of type int</param>
        /// <returns>Even numbers if an input have even numbers otherwise should returns an empty array</returns>
        public static int[] EvenNumbers(this int[] input) =>
            (input.Length != 0)
            ? input.Where(i => (i % 2) == 0).OrderBy(i => i).ToArray()
            : input;

    }

    
}
