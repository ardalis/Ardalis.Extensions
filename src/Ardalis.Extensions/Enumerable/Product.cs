using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ardalis.GuardClauses;

namespace Ardalis.Extensions.Enumerable;

public static partial class EnumerableExtensions
{
  public static int Product(this IEnumerable<int> source)
  {
    int product = 1;
    if (source.TryGetSpan(out ReadOnlySpan<int> span))
    {
      foreach (int v in span)
      {
        checked { product *= v; }
      }
    }
    else
    {
      foreach (int v in source)
      {
        checked { product *= v; }
      }
    }

    return product;
  }

  public static int? Product(this IEnumerable<int?> source)
  {
    Guard.Against.Null(source, nameof(source));

    int product = 1;
    checked
    {
      foreach (int? v in source)
      {
        if (v == null) return null;

        product *= (int)v;
      }
    }

    return product;
  }

  public static long Product(this IEnumerable<long> source)
  {
    long product = 1;
    if (source.TryGetSpan(out ReadOnlySpan<long> span))
    {
      foreach (long v in span)
      {
        checked { product *= v; }
      }
    }
    else
    {
      foreach (long v in source)
      {
        checked { product *= v; }
      }
    }

    return product;
  }

  public static long? Product(this IEnumerable<long?> source)
  {
    Guard.Against.Null(source, nameof(source));

    long product = 1;
    checked
    {
      foreach (long? v in source)
      {
        if (v == null) return null;

        product *= (long)v;
      }
    }

    return product;
  }

  public static float Product(this IEnumerable<float> source)
  {
    if (source.TryGetSpan(out ReadOnlySpan<float> span))
    {
      return (float)Product(span);
    }

    double product = 1;
    foreach (float v in source)
    {
      product *= v;
    }

    return (float)product;
  }

  private static double Product(ReadOnlySpan<float> span)
  {
    double product = 1;

    for (int i = 0; i < span.Length; i++)
    {
      product *= span[i];
    }

    return product;
  }

  public static float? Product(this IEnumerable<float?> source)
  {
    Guard.Against.Null(source, nameof(source));
    
    double product = 1;
    checked
    {
      foreach (float? v in source)
      {
        if (v == null) return null;

        product *= (double)v;
      }
    }

    return (float)product;
  }

  public static double Product(this IEnumerable<double> source)
  {
    if (source.TryGetSpan(out ReadOnlySpan<double> span))
    {
      return Product(span);
    }

    double product = 1;
    foreach (double v in source)
    {
      product *= v;
    }

    return product;
  }

  private static double Product(ReadOnlySpan<double> span)
  {
    double product = 1;

    for (int i = 0; i < span.Length; i++)
    {
      product *= span[i];
    }

    return product;
  }

  public static double? Product(this IEnumerable<double?> source)
  {
    Guard.Against.Null(source, nameof(source));
    
    double product = 1;
    checked
    {
      foreach (double? v in source)
      {
        if (v == null) return null;

        product *= (double)v;
      }
    }

    return product;
  }

    public static decimal Product(this IEnumerable<decimal> source)
  {
    if (source.TryGetSpan(out ReadOnlySpan<decimal> span))
    {
      return Product(span);
    }

    decimal product = 1;
    foreach (decimal d in source)
    {
      product *= d;
    }

    return product;
  }

  private static decimal Product(ReadOnlySpan<decimal> span)
  {
    decimal product = 1;

    foreach (decimal d in span)
    {
      product *= d;
    }

    return product;
  }

  public static decimal? Product(this IEnumerable<decimal?> source)
  {
    Guard.Against.Null(source, nameof(source));
    
    decimal product = 1;
    checked
    {
      foreach (decimal? v in source)
      {
        if (v == null) return null;

        product *= (decimal)v;
      }
    }

    return product;
  }

  // This method is heavily based on the a private method in the .NET Core source code.
  // It can be found here: https://github.com/dotnet/runtime/blob/e5faab09dde63855d1a624d12fede745cac43f88/src/libraries/System.Linq/src/System/Linq/Enumerable.cs
  // This code is licensed to the .NET Foundation under one or more agreements.
  // The .NET Foundation licenses this code to you under the MIT license.
  /// <summary>Validates that source is not null and then tries to extract a span from the source.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)] // fast type checks that don't add a lot of overhead
  private static bool TryGetSpan<TSource>(this IEnumerable<TSource> source, out ReadOnlySpan<TSource> span)
      // This constraint isn't required, but the overheads involved here can be more substantial when TSource
      // is a reference type and generic implementations are shared.  So for now we're protecting ourselves
      // and forcing a conscious choice to remove this in the future, at which point it should be paired with
      // sufficient performance testing.
      where TSource : struct
  {
    Guard.Against.Null(source, nameof(source));

    // Use `GetType() == typeof(...)` rather than `is` to avoid cast helpers.  This is measurably cheaper
    // but does mean we could end up missing some rare cases where we could get a span but don't (e.g. a uint[]
    // masquerading as an int[]).  That's an acceptable tradeoff.  The Unsafe usage is only after we've
    // validated the exact type; this could be changed to a cast in the future if the JIT starts to recognize it.
    // We only pay the comparison/branching costs here for super common types we expect to be used frequently
    // with LINQ methods.

    bool result = true;
    if (source.GetType() == typeof(TSource[]))
    {
      span = Unsafe.As<TSource[]>(source);
    }
    else if (source.GetType() == typeof(List<TSource>))
    {
      span = CollectionsMarshal.AsSpan(Unsafe.As<List<TSource>>(source));
    }
    else
    {
      span = default;
      result = false;
    }

    return result;
  }
}
