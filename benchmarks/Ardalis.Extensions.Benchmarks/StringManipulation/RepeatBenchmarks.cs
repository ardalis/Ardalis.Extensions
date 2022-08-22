using System.IO;
using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.StringManipulation;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Ardalis.Extensions.Benchmarks.StringManipulation;

[MemoryDiagnoser]
public class RepeatBenchmarks
{
  [Params(1, 10, 100)]
  public uint N { get; set; }
  

  [Benchmark(Baseline = true)]
  public string RepeatLinq()
  {
    return "abs".Repeat(N);
  }

  [Benchmark]
  public string RepeatStrBuilder()
  {
    return "abs".RepeatStrBuilder(N);
  }
}

static class RepeatBenchmarksExtensions
{
  public static string RepeatStrBuilder(this string text, uint n)
  {
    return new StringBuilder(text.Length * (int)n).Insert(0, text, (int)n).ToString();
  }
}
