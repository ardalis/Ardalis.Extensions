using System;

namespace Ardalis.Extensions.Encoding.Base64
{
    using System.Text; // This prevents the Encoding namespace conflict in this class

    public static partial class Base64Extensions
    {
        /// <summary>
        /// Encodes string to base64.
        /// 
        /// <br />Source: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
        /// </summary>
        /// <param name="plainText">String to encode.</param>
        /// <param name="encoding">Encoding to use. Defaults to Encoding.Default.</param>
        /// <returns>The base64 encoded version of the string</returns>
        /// <exception cref="EncoderFallbackException">
        /// A fallback occurred (see Character Encoding in the .NET Framework for complete 
        /// explanation) -and- System.Text.Encoding.EncoderFallback is set to System.Text.EncoderExceptionFallback.
        /// </exception>
        public static string ToBase64(this string @string, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(@string))
            {
                return string.Empty;
            }

            encoding ??= Encoding.Default;

            var stringBytes = encoding.GetBytes(@string);
            return Convert.ToBase64String(stringBytes);
        }
    }
}