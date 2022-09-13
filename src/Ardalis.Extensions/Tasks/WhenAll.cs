using System;
using System.Threading.Tasks;

namespace Ardalis.Extensions.Tasks;

public static partial class TasksExtensions
{
  public static Task<Tuple<T1>> WhenAll<T1>(this Tuple<Task<T1>> tasks)
  {
    return Task.WhenAll(tasks.Item1).ContinueWith(t => Tuple.Create(t.Result[0]));
  }
}