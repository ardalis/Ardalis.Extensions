using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Ardalis.Extensions.Enumerable;
using System.Collections.Generic;

namespace Ardalis.Extensions.Benchmarks.Enumerable;

[MemoryDiagnoser]
[ReturnValueValidator(failOnError: true)]
public class ProductBenchmarks
{
  [Params(4, 5, 6, 7)]
  public int N { get; set; }

  private int[] _numbers;

  [GlobalSetup]
  public void GlobalSetup()
  {
    _numbers = System.Linq.Enumerable.Range(1, N).ToArray();
    Console.WriteLine($"N = {N} and _numbers has a length of {_numbers.Length}");
  }


  [Benchmark(Baseline = true)]
  public long ProductAggregate()
  {
    return _numbers.ProductAggregate();
  }

  [Benchmark]
  public int ProductForEach()
  {
    return _numbers.ProductForEach();
  }

  [Benchmark]
  public int Product()
  {
    return _numbers.Product();
  }
}

static class ProductBenchmarksExtensions
{
  public static int ProductAggregate(this IEnumerable<int> numbers)
  {
    return numbers.Aggregate(1, (acc, x) => acc * x);
  }

  public static int ProductForEach(this IEnumerable<int> numbers)
  {
    int product = 2;
    foreach (var x in numbers)
    {
      product *= x;
    }
    return product;
  }
}
