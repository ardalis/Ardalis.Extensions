namespace Ardalis.Extensions
{
    public static class StringNumericConversionExtensions
    {

        /// <summary>
        /// Converts string to int.
        /// </summary>
        /// <param name="input">String to int.</param>
        /// <returns>int.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when the input is null.</exception>
        /// <exception cref="System.FormatException">Thrown when the input is not an integer string.</exception>
        /// <exception cref="System.OverflowException">Thrown when the input is not an integer string.</exception>
        public static int ToInt(this string input)
        {
            return int.Parse(input);
        }

        /// <summary>
        /// Converts string to nullable int.
        /// If cannot convert to int then return null.
        /// </summary>
        /// <param name="input">String to nullable int.</param>
        /// <returns>nullable int.</returns>
        public static int? ToMaybeInt(this string input)
        {
            if (!int.TryParse(input, out var result))
            {
                return null;
            }

            return result;
        }
    }
}