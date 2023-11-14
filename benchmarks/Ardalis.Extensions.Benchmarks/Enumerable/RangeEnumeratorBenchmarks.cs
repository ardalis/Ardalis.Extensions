using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.Enumerable;

namespace Ardalis.Extensions.Benchmarks.Enumerable;

[MemoryDiagnoser]
[ReturnValueValidator(failOnError: true)]
public class RangeEnumeratorBenchmarks
{
  [Params(10, 1000, 10000)]
  public int End { get; set; }

  [Benchmark(Baseline = true)]
  public void NormalForLoop()
  {
    for (int i = 0; i < End; i++)
    {
      DoNotOptimizeAway(i);
    }
  }
  
  [Benchmark]
  public void RangedForLoop()
  {
    foreach(var i in 0..End)
    {
      DoNotOptimizeAway(i);
    }
  }

  /// <summary>
  /// Prevent the compiler from optimizing away loop enumeration.
  /// </summary>
  /// <param name="i">Current loop value</param>
  private static void DoNotOptimizeAway(int i) { }
}
