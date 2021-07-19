using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ardalis.Extensions.Arrays
{
    public static class IntArrayExtensions
    {
        public static int[] OddNumbers(this int[] input) =>
            (input.Length != 0)
            ? input.Where(i => (i % 2) != 0).OrderBy(i => i).ToArray()
            : input;
            

        public static int[] EvenNumbers(this int[] input) =>
            (input.Length != 0)
            ? input.Where(i => (i % 2) == 0).OrderBy(i => i).ToArray()
            : input;

    }

    
}
