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
    return "abs".RepeatLinq(N);
  }

  [Benchmark]
  public string RepeatStrBuilder()
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
}
