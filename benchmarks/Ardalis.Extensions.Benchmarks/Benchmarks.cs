
using System.IO;
using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.StringManipulation;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Ardalis.Extensions.Benchmarks;

[MemoryDiagnoser]
public class Benchmarks
{
  private string Bible { get; set; }

  [Params(1, 5, 10, 15)]
  public int N { get; set; }
  public Benchmarks()
  {
    Bible = File.ReadAllText("bible.txt");
  }

  [Benchmark(Baseline = true)]
  public string[] LinesSplit()
  {
    return Bible.LinesSplit().Where((line, index) => index % N == 0).ToArray();
  }

  [Benchmark]
  public string[] LinesSubstring()
  {
    return Bible.LinesSub().Where((line, index) => index % N == 0).ToArray();
  }

  [Benchmark]
  public string[] LinesMemory()
  {
    return Bible.Lines().Where((line, index) => index % N == 0).Select(line => line.ToString()).ToArray();
  }
}

static class BenchmarksStringExtensions
{
  public static IEnumerable<string> LinesSplit(this string text)
  {

    var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

    if (lines.Last() == "") return lines.Take(lines.Length - 1).ToArray();

    return lines;
  }

  public static IEnumerable<string> LinesSub(this string text)
  {
    var lineStartIndex = 0;
    var currentIndex = 0;

    while (currentIndex < text.Length)
    {
      if (text[currentIndex] == '\n')
      {
        yield return text.Substring(lineStartIndex, currentIndex - lineStartIndex);
        lineStartIndex = currentIndex + 1;
        currentIndex++;
        continue;
      }

      if (text[currentIndex] == '\r')
      {
        if (currentIndex + 1 < text.Length && text[currentIndex + 1] == '\n')
        {
          yield return text.Substring(lineStartIndex, currentIndex - lineStartIndex);
          lineStartIndex = currentIndex + 2;
          currentIndex += 2;
          continue;
        }
      }

      if (currentIndex == text.Length - 1)
      {
        yield return text.Substring(lineStartIndex);
      }

      currentIndex++;
    }
  }

}