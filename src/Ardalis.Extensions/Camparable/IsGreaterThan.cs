namespace Ardalis.Extensions.Comparable
{
    public static partial class CamparableExtensions
    {
        /// <summary>
        /// Check if a number is greater than another number
        /// </summary>
        /// <param name="number">Number to compare.</param>
        /// <param name="value">Value to compare with a number.</param>
        /// <returns>True if number is greater than value otherwise false.</returns>
        public static bool IsGreaterThan(this int number, int value) => number > value;
    }
}