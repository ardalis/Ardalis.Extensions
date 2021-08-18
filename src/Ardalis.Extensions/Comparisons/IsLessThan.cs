namespace Ardalis.Extensions.Comparisons
{
    public static partial class CamparableExtensions
    {

        /// <summary>
        /// Check if a number is less than another number
        /// </summary>
        /// <param name="number">Number to compare.</param>
        /// <param name="value">Value to compare with a number.</param>
        /// <returns>True if number is less than value otherwise false.</returns>
        public static bool IsLessThan(this int number, int value) => number < value;
    }
}
