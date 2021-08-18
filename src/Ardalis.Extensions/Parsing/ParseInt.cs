namespace Ardalis.Extensions.Parsing
{
    public static partial class ParsingExtensions
    {
        /// <summary>
        /// Converts string to int.
        /// </summary>
        /// <param name="input">String to int.</param>
        /// <returns>int.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when the input is null.</exception>
        /// <exception cref="System.FormatException">Thrown when the input is not an integer string.</exception>
        /// <exception cref="System.OverflowException">Thrown when the input is not an integer string.</exception>
        public static int ParseInt(this string input)
        {
            return int.Parse(input);
        }
    }
}