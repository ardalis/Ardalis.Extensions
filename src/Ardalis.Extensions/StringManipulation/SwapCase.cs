using System.Text;

namespace Ardalis.Extensions.StringManipulation
{
    public static partial class StringManipulationExtensions
    {
        /// <summary>
        /// Returns a copy of the string with case swapped.
        /// </summary>
        /// <param name="text">String to case swap.</param>
        /// <returns>Obtain string with case swapped.</returns>
        public static string SwapCase(this string text)
        {
            if(string.IsNullOrEmpty(text))
            {
                return text;
            }

            var result = new StringBuilder();

            for(var i = 0; i < text.Length; i++)
            {
                if(char.IsUpper(text[i]))
                {
                    result.Append(text[i].ToString().ToLower());
                }else if (char.IsLower(text[i]))
                {
                    result.Append(text[i].ToString().ToUpper());
                }else
                {
                    result.Append(text[i]);
                }
            }
            
            return result.ToString();
        }
    }
}