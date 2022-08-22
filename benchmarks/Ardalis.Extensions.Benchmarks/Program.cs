using BenchmarkDotNet.Running;

namespace Ardalis.Extensions.Benchmarks;

public class Program
{
  public static void Main(string[] args)
  {
    BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
  }
}
