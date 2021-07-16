using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class UserTestClass
    {
        public string Name { get; set; }
    }

    public class StringExtensionsJson
    {
        public static IEnumerable<object[]> UserData
        {
            get
            {
                yield return new object[] { new UserTestClass { Name = "John" } };
            }
        }


        [Theory]
        [InlineData("{ \"Name\": \"John\" }")]
        public void ReturnsAnObjectFromJsonString(string input)
        {
            var result = input.FromJsonString<UserTestClass>();

            Assert.Equal(new UserTestClass { Name = "John" }.Name, result.Name);
        }

        [Theory]
        [MemberData(nameof(UserData))]
        public void ReturnsJsonStringFromAnObject(UserTestClass input)
        {
            string result = input.ToJsonString();

            Assert.Equal("{\"Name\":\"John\"}", result);
        }
    }
}
