using System.Collections.Generic;

namespace Ardalis.Extensions.UnitTests.Serialization.Json;

public partial class JsonTests
{
  public class UserTestClass
  {
    public string Name { get; set; }
  }

  public static IEnumerable<object[]> UserData
  {
    get
    {
      yield return new object[] { new UserTestClass { Name = "John" } };
    }
  }
}
