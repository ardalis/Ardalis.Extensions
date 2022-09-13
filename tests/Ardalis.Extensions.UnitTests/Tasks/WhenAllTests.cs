using System;
using System.Threading.Tasks;
using Ardalis.Extensions.Tasks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Tasks;

public class WhenAllTests
{

  [Fact]
  public async Task TakesTupleOfTwoTasksAndReturnsTupleOfTwoResult()
  {
    var tasks = (GetIntAsync(1), GetStringAsync("Two"));

    var result = await tasks.WhenAll();

    Assert.Equal((1, "Two"), result);
  }

  [Fact]
  public async Task TakesTupleOfThreeTasksAndReturnsTupleOfThreeResult()
  {
    var tasks = (GetIntAsync(1), GetStringAsync("Two"), GetDateTimeAsync(3));

    var result = await tasks.WhenAll();

    Assert.Equal((1, "Two", new DateTime(3)), result);
  }

  [Fact]
  public async Task TakesTupleOfFourTasksAndReturnsTupleOfFourResult()
  {
    var tasks = (GetIntAsync(1), GetStringAsync("Two"), GetDateTimeAsync(3), GetIntAsync(4));

    var result = await tasks.WhenAll();

    Assert.Equal((1, "Two", new DateTime(3), 4), result);
  }

  [Fact]
  public async Task TakesTupleOfFiveTasksAndReturnsTupleOfFiveResult()
  {
    var tasks = (GetIntAsync(1), GetStringAsync("Two"), GetDateTimeAsync(3), GetIntAsync(4), GetStringAsync("Five"));

    var result = await tasks.WhenAll();

    Assert.Equal((1, "Two", new DateTime(3), 4, "Five"), result);
  }

  [Fact]
  public async Task TakesTupleOfSixTasksAndReturnsTupleOfSixResult()
  {
    var tasks = (
      GetIntAsync(1), GetStringAsync("Two"), GetDateTimeAsync(3), GetIntAsync(4), GetStringAsync("Five"), GetDateTimeAsync(6)
      );

    var result = await tasks.WhenAll();

    Assert.Equal((1, "Two", new DateTime(3), 4, "Five", new DateTime(6)), result);
  }

  [Fact]
  public async Task ThrowsWhenATaskThrows()
  {
    var tasks = (GetIntAsync(1), GetExceptionAsync(), GetDateTimeAsync(3));

    await Assert.ThrowsAsync<AggregateException>(() => tasks.WhenAll());
  }

  [Fact]
  public async Task ThrowsWhenMoreThanOneTaskThrows()
  {
    var tasks = (GetExceptionAsync("First"), GetExceptionAsync("Second"), GetDateTimeAsync(3));

    var exception = await Assert.ThrowsAsync<AggregateException>(() => tasks.WhenAll());
    Assert.Equal("First", exception.InnerExceptions[0].Message);
    Assert.Equal("Second", exception.InnerExceptions[1].Message);
  }

  private Task<int> GetIntAsync(int value)
  {
    return Task.FromResult(value);
  }

  private Task<string> GetStringAsync(string value)
  {
    return Task.FromResult(value);
  }

  private Task<DateTime> GetDateTimeAsync(long value)
  {
    return Task.FromResult(new DateTime(value));
  }

  private async Task<int> GetExceptionAsync(string message = null)
  {
    for (var i = 0; i <= 10; i++)
    {
      await Task.Delay(1);
      if (i == 2)
      {
        throw new Exception(message);
      }
    }
    return 44;
  }
}
