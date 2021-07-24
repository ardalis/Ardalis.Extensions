using Xunit;
using Ardalis.Extensions.Serialization.Json;

namespace Ardalis.Extensions.UnitTests.Serialization.Json
{
    public partial class JsonTests
    {
        [Theory]
        [MemberData(nameof(UserData))]
        public void ReturnsJsonStringFromAnObject(UserTestClass input)
        {
            string result = input.ToJson();

            Assert.Equal("{\"Name\":\"John\"}", result);
        }
    }
}
