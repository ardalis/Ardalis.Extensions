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
    var tasks = (GetIntAsync(), GetExceptionAsync(1), GetDateTimeAsync());

    await Assert.ThrowsAsync<WhenAllException>( () => tasks.WhenAll());
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

  private async Task<int> GetExceptionAsync(int milliseconds)
  { 
    for (var i = 0; i <= milliseconds; i++)
    {
      await Task.Delay(1);
      if (i == milliseconds)
      {
        throw new WhenAllException("OMG, an exception!");
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