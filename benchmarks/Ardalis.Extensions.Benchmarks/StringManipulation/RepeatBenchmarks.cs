using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.StringManipulation;
using System.Text;

namespace Ardalis.Extensions.Benchmarks.StringManipulation;

[MemoryDiagnoser]
public class RepeatBenchmarks
{
  [Params(1, 10, 100, 1000)]
  public uint N { get; set; }
  

  [Benchmark(Baseline = true)]
  public string RepeatLinq()
  {
    return "abs".RepeatLinq(N);
  }

  [Benchmark]
  public string RepeatStrBuilder()
  {
    return "abs".RepeatStrBuilder(N);
  }

  [Benchmark]
  public string RepeatArray()
  {
    return "abs".RepeatArray(N);
  }

  [Benchmark]
  public string RepeatSpan()
  {
    return "abs".Repeat(N);
  }
}

static class RepeatBenchmarksExtensions
{
  public static string RepeatLinq(this string text, uint n)
  {
    return string.Concat(System.Linq.Enumerable.Repeat(text, (int)n));
  }

  public static string RepeatStrBuilder(this string text, uint n)
  {
    return new StringBuilder(text.Length * (int)n).Insert(0, text, (int)n).ToString();
  }

  public static string RepeatArray(this string text, uint n)
  {
    var arr = new char[text.Length * (int)n];
    for (var i = 0; i < n; i++)
    {
      text.CopyTo(0, arr, i * text.Length, text.Length);
    }

    return arr.ToString();
  }
}
