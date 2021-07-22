using Xunit;
using Ardalis.Extensions.Serialization.Json;

namespace Ardalis.Extensions.UnitTests.Serialization.Json
{
    public partial class JsonTests
    {
        [Theory]
        [InlineData("{ \"Name\": \"John\" }")]
        public void ReturnsAnObjectFromJsonString(string input)
        {
            var result = input.FromJson<UserTestClass>();

            Assert.Equal(new UserTestClass { Name = "John" }.Name, result.Name);
        }
    }
}