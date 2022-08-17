using BenchmarkDotNet.Running;

namespace Ardalis.Extensions.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}