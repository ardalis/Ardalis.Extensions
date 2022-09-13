using System;
using System.Threading.Tasks;

namespace Ardalis.Extensions.Tasks;

public static partial class TasksExtensions
{

  public static async Task<(T1, T2)> WhenAll<T1, T2>(this (Task<T1>, Task<T2>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2);
    try 
    {
      await task;
    } catch (Exception) {
      throw task.Exception;
    }

    return (tasks.Item1.Result, tasks.Item2.Result);
  }

  public static async Task<(T1, T2, T3)> WhenAll<T1, T2, T3>(this (Task<T1>, Task<T2>, Task<T3>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3);
    try 
    {
      await task;
    }
    catch (Exception)
    {
      throw task.Exception;
    }
    
    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result);
  }

  public static async Task<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3);
    try 
    {
      await task;
    }
    catch (Exception)
    {
      throw task.Exception;
    }
    
    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3);
    try 
    {
      await task;
    }
    catch (Exception)
    {
      throw task.Exception;
    }
    
    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3);
    try 
    {
      await task;
    }
    catch (Exception)
    {
      throw task.Exception;
    }
    
    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, 
      tasks.Item4.Result, tasks.Item5.Result, tasks.Item6.Result);
  }
}