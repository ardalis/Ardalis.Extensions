using System;
using System.Collections.Generic;
using System.Text;

namespace Ardalis.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Check if a number is greater than another number or not
        /// </summary>
        /// <param name="number">Number to compare.</param>
        /// <param name="value">Value to compare with a number.</param>
        /// <returns>True if number is greater than value otherwise false.</returns>
        public static bool IsGreaterThan(this int number,int value) => number > value;

    }
}
