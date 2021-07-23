namespace Ardalis.Extensions.Parsing
{
    public static partial class NumberParsingExtensions
    {
        /// <summary>
        /// Converts string to nullable int.
        /// If cannot convert to int then return null.
        /// </summary>
        /// <param name="input">String to nullable int.</param>
        /// <returns>nullable int.</returns>
        public static int? ParseNullableInt(this string input)
        {
            if (!int.TryParse(input, out var result))
            {
                return null;
            }

            return result;
        }
    }
}