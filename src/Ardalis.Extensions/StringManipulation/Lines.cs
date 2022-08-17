using System;
using System.Linq;
using System.Collections.Generic;

namespace Ardalis.Extensions.StringManipulation;

public static partial class StringManipulationExtensions
{
  public static string[] Lines(this string text)
  {
    
    var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

    if (lines.Last() == "") return lines.Take(lines.Length - 1).ToArray();
    
    return lines;
  }
}