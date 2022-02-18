using System;
using System.Text.RegularExpressions;

namespace Ardalis.Extensions.Encoding.Base64;

using System.Text; // This prevents the Encoding namespace conflict in this class

public static partial class Base64Extensions
{

  /// <summary>
  /// Decodes string from base64 to its normal representation.
  /// 
  /// Source: https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
  /// Source: https://www.aspforums.net/Threads/567945/Check-if-Base64-string-is-Valid-or-not-using-C-and-VBNet-in-ASPNet/
  /// </summary>
  /// <param name="encodedString">String to encode.</param>
  /// <returns>The decoded version of the string</returns>        
  public static string FromBase64(
     this string encodedString, Encoding encoding = null)
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
}
