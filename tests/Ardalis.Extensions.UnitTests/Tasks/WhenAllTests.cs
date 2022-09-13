using System;
using System.Threading.Tasks;
using Ardalis.Extensions.Tasks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Tasks;

public class WhenAllTests
{
  private readonly int _expectedInt = 1;
  private readonly string _expectedString = "test";
  private readonly DateTime _expectedDateTime = new DateTime(2022, 1, 1);

  [Fact]
  public async Task TakesTupleOfTwoTasksAndReturnsTupleOfTwoResult()
  {
    var tasks = (GetIntAsync(), GetStringAsync());

    var result = await tasks.WhenAll();

    Assert.Equal((_expectedInt, _expectedString), result);
  }

  [Fact]
  public async Task TakesTupleOfThreeTasksAndReturnsTupleOfThreeResult()
  {
    var tasks = (GetIntAsync(), GetStringAsync(), GetDateTimeAsync());

    var result = await tasks.WhenAll();

    Assert.Equal((_expectedInt, _expectedString, _expectedDateTime), result);
  }

  [Fact]
  public async Task ThrowsWhenATaskThrows()
  {
    var tasks = (GetIntAsync(), GetExceptionAsync(), GetDateTimeAsync());

    await Assert.ThrowsAsync<AggregateException>(() => tasks.WhenAll());
  }

  [Fact]
  public async Task ThrowsWhenMoreThanOneTaskThrows()
  {
    var tasks = (GetExceptionAsync("First"), GetExceptionAsync("Second"), GetDateTimeAsync());

    var exception = await Assert.ThrowsAsync<AggregateException>(() => tasks.WhenAll());
    Assert.Equal("First", exception.InnerExceptions[0].Message);
    Assert.Equal("Second", exception.InnerExceptions[1].Message);
  }

  private Task<int> GetIntAsync()
  {
    return Task.FromResult(_expectedInt);
  }

  private Task<string> GetStringAsync()
  {
    return Task.FromResult(_expectedString);
  }

  private Task<DateTime> GetDateTimeAsync()
  {
    return Task.FromResult(_expectedDateTime);
  }

  private async Task<int> GetExceptionAsync(string message = null)
  {
    for (var i = 0; i <= 10; i++)
    {
      await Task.Delay(1);
      if (i == 2)
      {
        throw new WhenAllException(message);
      }
    }
    return 44;
  }
}

class WhenAllException : Exception
{
  public WhenAllException(string message) : base(message)
  {
  }
}