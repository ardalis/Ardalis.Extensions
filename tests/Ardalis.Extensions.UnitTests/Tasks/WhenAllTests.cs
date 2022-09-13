using System;
using System.Threading.Tasks;
using Ardalis.Extensions.Tasks;
using Xunit;

namespace Ardalis.Extensions.UnitTests.Tasks;

public class WhenAllTests
{
  private readonly int _expectedInt = 1;
  private readonly string _expectedString = "test";

  [Fact]
  public async Task TakesTupleOfTwoTaskAndReturnsTupleOfOneResult()
  {
    var tasks = (GetIntAsync(), GetStringAsync());

    var result = await tasks.WhenAll();

    Assert.Equal((_expectedInt, _expectedString), result);
  }

  private Task<int> GetIntAsync()
  {
    return Task.FromResult(_expectedInt);
  }

  private Task<string> GetStringAsync()
  {
    return Task.FromResult(_expectedString);
  }
}