using BenchmarkDotNet.Running;
using Ardalis.Extensions.Benchmarks.StringManipulation;

namespace Ardalis.Extensions.Benchmarks;

public class Program
{
  public static void Main(string[] args)
  {
    var summary = BenchmarkRunner.Run<LinesBenchmarks>();
  }
}
