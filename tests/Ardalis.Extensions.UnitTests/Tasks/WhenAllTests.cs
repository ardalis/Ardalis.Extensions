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
  public async Task TakesTupleOfOneTaskAndReturnsTupleOfOneResult()
  {
    var tasks = Tuple.Create(GetIntAsync());

    var result = await tasks.WhenAll();

    Assert.Equal(_expectedInt, result.Item1);
  }

  private async Task<int> GetIntAsync()
  {
    await Task.Delay(1);
    return _expectedInt;
  }

  private async Task<string> GetStringAsync()
  {
    await Task.Delay(1);
    return _expectedString;
  }
}