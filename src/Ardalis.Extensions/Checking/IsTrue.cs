using System;
using System.Collections.Generic;
using System.Text;

namespace Ardalis.Extensions.Checking
{
    public static partial class CheckingExtensionMethods
    {
        /// <summary>
        /// Checks if a given condition is true
        /// </summary>
        /// <param name="value">value to check is true.</param>
        /// <returns>True if value true otherwise false.</returns>
        public static bool IsTrue(this bool value) => value;
    }
}
