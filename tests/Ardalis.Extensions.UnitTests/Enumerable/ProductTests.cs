using System;
using System.Collections.Generic;
using System.Linq;
using Ardalis.Extensions.Enumerable;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Enumerables;

public class ProducTests
{
  #region SourceIsNull - ArgumentNullExceptionThrown

  [Fact]
  public void ProductOfInt_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<int> sourceInt = null;
    Assert.Throws<ArgumentNullException>(() => sourceInt.Product());
  }

  [Fact]
  public void ProductOfNullableInt_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<int?> sourceNullableInt = null;
    Assert.Throws<ArgumentNullException>(() => sourceNullableInt.Product());
  }

  [Fact]
  public void ProductOfLong_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<long> sourceLong = null;
    Assert.Throws<ArgumentNullException>(() => sourceLong.Product());
  }

  [Fact]
  public void ProductOfNullableLong_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<long?> sourceNullableLong = null;
    Assert.Throws<ArgumentNullException>(() => sourceNullableLong.Product());
  }

  [Fact]
  public void ProductOfFloat_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<float> sourceFloat = null;
    Assert.Throws<ArgumentNullException>(() => sourceFloat.Product());
  }

  [Fact]
  public void ProductOfNullableFloat_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<float?> sourceNullableFloat = null;
    Assert.Throws<ArgumentNullException>(() => sourceNullableFloat.Product());
  }

  [Fact]
  public void ProductOfDouble_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<double> sourceDouble = null;
    Assert.Throws<ArgumentNullException>(() => sourceDouble.Product());
  }

  [Fact]
  public void ProductOfNullableDouble_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<double?> sourceNullableDouble = null;
    Assert.Throws<ArgumentNullException>(() => sourceNullableDouble.Product());
  }

  [Fact]
  public void ProductOfDecimal_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<decimal> sourceDecimal = null;
    Assert.Throws<ArgumentNullException>(() => sourceDecimal.Product());
  }

  [Fact]
  public void ProductOfNullableDecimal_SourceIsNull_ArgumentNullExceptionThrown()
  {
    IEnumerable<decimal?> sourceNullableDecimal = null;
    Assert.Throws<ArgumentNullException>(() => sourceNullableDecimal.Product());
  }

  #endregion

  #region SourceIsEmptyCollection - OneReturned

  [Fact]
  public void ProductOfInt_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<int> sourceInt = System.Linq.Enumerable.Empty<int>();
    Assert.Equal(1, sourceInt.Product());
  }

  [Fact]
  public void ProductOfNullableInt_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<int?> sourceNullableInt = System.Linq.Enumerable.Empty<int?>();
    Assert.Equal(1, sourceNullableInt.Product());
  }

  [Fact]
  public void ProductOfLong_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<long> sourceLong = System.Linq.Enumerable.Empty<long>();
    Assert.Equal(1L, sourceLong.Product());
  }

  [Fact]
  public void ProductOfNullableLong_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<long?> sourceNullableLong = System.Linq.Enumerable.Empty<long?>();
    Assert.Equal(1L, sourceNullableLong.Product());
  }

  [Fact]
  public void ProductOfFloat_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<float> sourceFloat = System.Linq.Enumerable.Empty<float>();
    Assert.Equal(1f, sourceFloat.Product());
  }

  [Fact]
  public void ProductOfNullableFloat_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<float?> sourceNullableFloat = System.Linq.Enumerable.Empty<float?>();
    Assert.Equal(1f, sourceNullableFloat.Product());
  }

  [Fact]
  public void ProductOfDouble_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<double> sourceDouble = System.Linq.Enumerable.Empty<double>();
    Assert.Equal(1d, sourceDouble.Product());
  }

  [Fact]
  public void ProductOfNullableDouble_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<double?> sourceNullableDouble = System.Linq.Enumerable.Empty<double?>();
    Assert.Equal(1d, sourceNullableDouble.Product());
  }

  [Fact]
  public void ProductOfDecimal_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<decimal> sourceDecimal = System.Linq.Enumerable.Empty<decimal>();
    Assert.Equal(1m, sourceDecimal.Product());
  }

  [Fact]
  public void ProductOfNullableDecimal_SourceIsEmptyCollection_OneReturned()
  {
    IEnumerable<decimal?> sourceNullableDecimal = System.Linq.Enumerable.Empty<decimal?>();
    Assert.Equal(1m, sourceNullableDecimal.Product());
  }

  #endregion

  #region SourceIsNotEmpty - ProperProductReturned

  [Fact]
  public void ProductOfInt_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<int> sourceInt = new int[] { 0, 1, -2, 3, -4 };
    Assert.Equal(0, sourceInt.Product());
    Assert.Equal(24, sourceInt.Skip(1).Product());
  }

  [Fact]
  public void ProductOfNullableOfInt_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<int?> sourceNullableInt = new int?[] { 0, 1, -2, 3, -4 };
    Assert.Equal(0, sourceNullableInt.Product());
    Assert.Equal(24, sourceNullableInt.Skip(1).Product());

    sourceNullableInt = new int?[] { 1, -2, null, 3, -4, null };
    Assert.Equal(null, sourceNullableInt.Product());
  }

  [Fact]
  public void ProductOfLong_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<long> sourceLong = new long[] { 0L, 1L, -2L, 3L, -4L };
    Assert.Equal(0L, sourceLong.Product());
    Assert.Equal(24L, sourceLong.Skip(1).Product());
  }

  [Fact]
  public void ProductOfNullableOfLong_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<long?> sourceNullableLong = new long?[] { 0L, 1L, -2L, 3L, -4L };
    Assert.Equal(0L, sourceNullableLong.Product());
    Assert.Equal(24L, sourceNullableLong.Skip(1).Product());

    sourceNullableLong = new long?[] { 1L, -2L, null, 3L, -4L, null };
    Assert.Equal(null, sourceNullableLong.Product());
  }

  [Fact]
  public void ProductOfFloat_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<float> sourceFloat = new float[] { 0f, 1f, -2.5f, 3f, -4.5f };
    Assert.Equal(0f, sourceFloat.Product());
    Assert.Equal(33.75f, sourceFloat.Skip(1).Product());
  }

  [Fact]
  public void ProductOfNullableOfFloat_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<float?> sourceNullableFloat = new float?[] { 0f, 1f, -2.5f, 3f, -4.5f };
    Assert.Equal(0f, sourceNullableFloat.Product());
    Assert.Equal(33.75f, sourceNullableFloat.Skip(1).Product());

    sourceNullableFloat = new float?[] { 1f, -2.5f, null, 3f, -4.5f, null };
    Assert.Equal(null, sourceNullableFloat.Product());
  }

  [Fact]
  public void ProductOfDouble_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<double> sourceDouble = new double[] { 0d, 1d, -2.5d, 3d, -4.5d };
    Assert.Equal(0d, sourceDouble.Product());
    Assert.Equal(33.75d, sourceDouble.Skip(1).Product());
  }

  [Fact]
  public void ProductOfNullableOfDouble_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<double?> sourceNullableDouble = new double?[] { 0d, 1d, -2.5d, 3d, -4.5d };
    Assert.Equal(0d, sourceNullableDouble.Product());
    Assert.Equal(33.75d, sourceNullableDouble.Skip(1).Product());

    sourceNullableDouble = new double?[] { 1, -2, null, 3, -4, null };
    Assert.Equal(null, sourceNullableDouble.Product());
  }

  [Fact]
  public void ProductOfDecimal_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<decimal> sourceDecimal = new decimal[] { 0m, 1m, -2.5m, 3m, -4.5m };
    Assert.Equal(0m, sourceDecimal.Product());
    Assert.Equal(33.75m, sourceDecimal.Skip(1).Product());
  }

  [Fact]
  public void ProductOfNullableOfDecimal_SourceIsNotEmpty_ProperProductReturned()
  {
    IEnumerable<decimal?> sourceNullableDecimal = new decimal?[] { 0m, 1m, -2.5m, 3m, -4.5m };
    Assert.Equal(0m, sourceNullableDecimal.Product());
    Assert.Equal(33.75m, sourceNullableDecimal.Skip(1).Product());

    sourceNullableDecimal = new decimal?[] { 1, -2, null, 3, -4, null };
    Assert.Equal(null, sourceNullableDecimal.Product());
  }

  #endregion

  #region SourceMultipliesToOverflow - OverflowExceptionThrown or Infinity returned

  [Fact]
  public void ProductOfInt_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<int> sourceInt = new int[] { int.MaxValue, 2 };
    Assert.Throws<OverflowException>(() => sourceInt.Product());
  }

  [Fact]
  public void ProductOfNullableOfInt_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<int?> sourceNullableInt = new int?[] { int.MaxValue, 2 };
    Assert.Throws<OverflowException>(() => sourceNullableInt.Product());
  }

  [Fact]
  public void ProductOfLong_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<long> sourceLong = new long[] { long.MaxValue, 2L };
    Assert.Throws<OverflowException>(() => sourceLong.Product());
  }

  [Fact]
  public void ProductOfNullableOfLong_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<long?> sourceNullableLong = new long?[] { long.MaxValue, 2L };
    Assert.Throws<OverflowException>(() => sourceNullableLong.Product());
  }

  [Fact]
  public void ProductOfFloat_SourceMultipliesToOverflow_InfinityReturned()
  {
    IEnumerable<float> sourceFloat = new float[] { float.MaxValue, float.MaxValue };
    Assert.True(float.IsPositiveInfinity(sourceFloat.Product()));
  }

  [Fact]
  public void ProductOfNullableOfFloat_SourceMultipliesToOverflow_InfinityReturned()
  {
    IEnumerable<float?> sourceNullableFloat = new float?[] { float.MaxValue, float.MaxValue };
    Assert.True(float.IsPositiveInfinity(sourceNullableFloat.Product().Value));
  }

  [Fact]
  public void ProductOfDouble_SourceMultipliesToOverflow_InfinityReturned()
  {
    IEnumerable<double> sourceDouble = new double[] { double.MaxValue, double.MaxValue };
    Assert.True(double.IsPositiveInfinity(sourceDouble.Product()));
  }

  [Fact]
  public void ProductOfNullableOfDouble_SourceMultipliesToOverflow_InfinityReturned()
  {
    IEnumerable<double?> sourceNullableDouble = new double?[] { double.MaxValue, double.MaxValue };
    Assert.True(double.IsPositiveInfinity(sourceNullableDouble.Product().Value));
  }

  [Fact]
  public void ProductOfDecimal_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<decimal> sourceDecimal = new decimal[] { decimal.MaxValue, 2m };
    Assert.Throws<OverflowException>(() => sourceDecimal.Product());
  }

  [Fact]
  public void ProductOfNullableOfDecimal_SourceMultipliesToOverflow_OverflowExceptionThrown()
  {
    IEnumerable<decimal?> sourceNullableDecimal = new decimal?[] { decimal.MaxValue, 2m };
    Assert.Throws<OverflowException>(() => sourceNullableDecimal.Product());
  }

  #endregion
}
