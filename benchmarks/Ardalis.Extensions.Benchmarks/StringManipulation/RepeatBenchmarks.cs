using System.Text;
using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.StringManipulation;
using System;

namespace Ardalis.Extensions.Benchmarks.StringManipulation;

[MemoryDiagnoser]
[ReturnValueValidator(failOnError: true)]
public class RepeatBenchmarks
{
  [Params(1u, 10u, 100u, 1000u)]
  public uint N { get; set; }
  

  [Benchmark(Baseline = true)]
  public string RepeatLinq()
  {
    return "abc".RepeatLinq(N);
  }

  [Benchmark]
  public string RepeatStrBuilder()
  {
    return "abc".RepeatStrBuilder(N);
  }

  [Benchmark]
  public string RepeatArray()
  {
    return "abc".RepeatArray(N);
  }

  [Benchmark]
  public string RepeatSpan()
  {
    return "abc".RepeatSpan(N);
  }

  [Benchmark]
  public string RepeatStringCreate()
  {
    return "abc".RepeatStringCreate(N);
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

    return new string(arr);
  }

  public static string RepeatSpan(this string text, uint n)
  {
    var textAsSpan = text.AsSpan();
    var span = new Span<char>(new char[textAsSpan.Length * (int)n]);
    for (var i = 0; i < n; i++)
    {
      textAsSpan.CopyTo(span.Slice((int)i * textAsSpan.Length, textAsSpan.Length));
    }

    return span.ToString();
  }

  public static string RepeatStringCreate(this string text, uint n)
  {
    return text.Repeat(n);
  }
}
