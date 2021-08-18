namespace Ardalis.Extensions.Parsing
{
    public static partial class ParsingExtensions
    {
        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="input">A string containing a number to convert</param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParseInt(this string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}