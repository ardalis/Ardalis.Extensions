using System;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Ardalis.Extensions
{
    public static class StringEncodingExtensions
    {
        /// <summary>
        /// Encodes string to base64.
        /// 
        /// Source: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
        /// </summary>
        /// <param name="plainText">String to encode.</param>
        /// <returns>The base64 encoded version of the string</returns>        
        public static string Base64Encode(this string plainText,
            Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return string.Empty;
            }

            encoding = encoding ?? Encoding.Default;
            var plainTextBytes = encoding.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Decodes string from base64 to its normal representation.
        /// 
        /// Source: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
        /// Source: https://www.aspforums.net/Threads/567945/Check-if-Base64-string-is-Valid-or-not-using-C-and-VBNet-in-ASPNet/
        /// </summary>
        /// <param name="encodedString">String to encode.</param>
        /// <returns>The decoded version of the string</returns>        
        public static string DecodeBase64String(this string encodedString,
            Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(encodedString))
            {
                return string.Empty;
            }

            // Check for valid base64
            encodedString = encodedString.Trim();
            var isValidBase64 = (encodedString.Length % 4 == 0) &&
                                Regex.IsMatch(encodedString, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

            if (!isValidBase64)
            {
                throw new ArgumentException($"{encodedString} is not valid base64");
            }

            var data = Convert.FromBase64String(encodedString);
            encoding = encoding ?? Encoding.Default;
            return encoding.GetString(data);
        }

        /// <summary>
        /// Converts JSON string to the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T FromJsonString<T>(this string t)
        {
            var value = JsonSerializer.Deserialize<T>(t);

            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Converts a Type to a JSON string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ToJsonString<T>(this T t)
        {
            var value = JsonSerializer.Serialize(t);

            return value;
        }
    }
}