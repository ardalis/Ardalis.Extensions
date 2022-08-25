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
  [Params(1, 10, 100, 1000)]
  public int N { get; set; }

  private double[] _numbers;

  [GlobalSetup]
  public void GlobalSetup()
  {
    _numbers = System.Linq.Enumerable.Range(1, N).Select(x => x % 2 == 0 ? x : 0.01d).ToArray();
  }


  [Benchmark(Baseline = true)]
  public double ProductAggregate()
  {
    return _numbers.ProductAggregate();
  }

  [Benchmark]
  public double ProductForEach()
  {
    return _numbers.ProductForEach();
  }

  [Benchmark]
  public double Product()
  {
    return _numbers.Product();
  }
}

static class ProductBenchmarksExtensions
{
  public static double ProductAggregate(this IEnumerable<double> numbers)
  {
    return numbers.Aggregate(1d, (acc, x) => acc * x);
  }

  public static double ProductForEach(this IEnumerable<double> numbers)
  {
    double product = 1d;
    foreach (var x in numbers)
    {
      product *= x;
    }
    return product;
  }
}
