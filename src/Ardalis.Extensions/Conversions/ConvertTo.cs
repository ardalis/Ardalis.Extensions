using System;

namespace Ardalis.Extensions.Conversions;

public static partial class ConvertibleExtensions
{
  /// <summary>
  /// Converts an IConvertable struct to the desired output Type.
  /// </summary>
  /// <typeparam name="TOut"></typeparam>
  /// <typeparam name="TIn"></typeparam>
  /// <param name="value">A struct object that implements the System.IConvertible interface.</param>
  /// <returns>An object of specified type, whose value is equivalent to the original object.</returns>
  /// <exception cref="System.InvalidCastException">
  /// This conversion is not supported.
  /// -or- value is null and conversionType is a value type.
  /// -or- value does not implement the System.IConvertible interface.
  /// </exception>
  /// <exception cref="System.FormatException">value is not in a format recognized by conversionType.</exception>
  /// <exception cref="System.OverflowException">value represents a number that is out of the range of the Type being converted to.</exception>
  public static TOut ConvertTo<TIn, TOut>(this TIn value) where TIn : struct, IConvertible
  {
    return (TOut)Convert.ChangeType(value, typeof(TOut));
  }
}
