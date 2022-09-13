using System;
using System.Threading.Tasks;

namespace Ardalis.Extensions.Tasks;

public static partial class TasksExtensions
{

  public static async Task<(T1, T2)> WhenAll<T1, T2>(this (Task<T1>, Task<T2>) tasks)
  {
    await Task.WhenAll(tasks.Item1, tasks.Item2);
    return (tasks.Item1.Result, tasks.Item2.Result);
  }

  public static async Task<(T1, T2, T3)> WhenAll<T1, T2, T3>(this (Task<T1>, Task<T2>, Task<T3>) tasks)
  {
    await Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3);
    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result);
  }
}