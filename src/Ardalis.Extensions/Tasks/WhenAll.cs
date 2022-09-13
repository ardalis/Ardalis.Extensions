using System;
using System.Threading.Tasks;

namespace Ardalis.Extensions.Tasks;

public static partial class TasksExtensions
{

  /// <summary>
  /// Creates a task that will complete when all of the supplied tasks have completed.
  /// </summary>
  /// <param name="tasks">The tasks to wait on for completion.</param>
  /// <returns>A task that represents the completion of all of the supplied tasks.</returns>
  /// <remarks>
  /// <para>
  /// If any of the supplied tasks completes in a faulted state, the returned task will also complete in a Faulted state,
  /// where its exceptions will contain the aggregation of the set of unwrapped exceptions from each of the supplied tasks.
  /// </para>
  /// <para>
  /// If none of the supplied tasks faulted but at least one of them was canceled, the returned task will end in the Canceled state.
  /// </para>
  /// <para>
  /// If none of the tasks faulted and none of the tasks were canceled, the resulting task will end in the RanToCompletion state.
  /// </para>
  /// </remarks>
  /// <exception cref="System.ArgumentException">
  /// The <paramref name="tasks"/> tuple contained a null task.
  /// </exception>
  public static async Task<(T1, T2)> WhenAll<T1, T2>(this (Task<T1>, Task<T2>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
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
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result);
  }

  public static async Task<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(this (Task<T1>, Task<T2>, Task<T3>, Task<T4>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result,
      tasks.Item6.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6,
      tasks.Item7);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result,
      tasks.Item6.Result, tasks.Item7.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>, Task<T8>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6,
      tasks.Item7, tasks.Item8);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result,
      tasks.Item6.Result, tasks.Item7.Result, tasks.Item8.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>, Task<T8>, Task<T9>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6,
      tasks.Item7, tasks.Item8, tasks.Item9);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result,
      tasks.Item6.Result, tasks.Item7.Result, tasks.Item8.Result, tasks.Item9.Result);
  }

  public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
    this (Task<T1>, Task<T2>, Task<T3>, Task<T4>, Task<T5>, Task<T6>, Task<T7>, Task<T8>, Task<T9>, Task<T10>) tasks)
  {
    var task = Task.WhenAll(tasks.Item1, tasks.Item2, tasks.Item3, tasks.Item4, tasks.Item5, tasks.Item6,
      tasks.Item7, tasks.Item8, tasks.Item9, tasks.Item10);
    try
    {
      await task;
    }
    catch (Exception e)
    {
      if (task.Exception != null)
      {
        throw task.Exception;
      }

      throw e;
    }

    return (
      tasks.Item1.Result, tasks.Item2.Result, tasks.Item3.Result, tasks.Item4.Result, tasks.Item5.Result,
      tasks.Item6.Result, tasks.Item7.Result, tasks.Item8.Result, tasks.Item9.Result, tasks.Item10.Result);
  }
}
