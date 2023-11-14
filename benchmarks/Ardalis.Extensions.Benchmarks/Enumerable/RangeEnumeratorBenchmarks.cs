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
      DoSomething(i);
    }
  }
  
  [Benchmark]
  public void RangedForLoop()
  {
    foreach(var i in 0..End)
    {
      DoSomething(i);
    }
  }

  // Prevent the compiler from optimizing away the loop
  private static void DoSomething(int i) { }
}
