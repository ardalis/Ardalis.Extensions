using Ardalis.Extensions.Encoding.Base64;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class FromBase64Tests
    {
        [Theory]
        [InlineData("SGVsbG8sV29ybGQ=")]
        public void ReturnsCorrectBase64RepresentationOfString(string input)
        {
            const string expectedValue = "Hello,World";
            
            var result = input.FromBase64();

            Assert.Equal(expectedValue, result);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
        {
            const string expectedValue = "";
            
            var result = input.FromBase64();

            Assert.Equal(expectedValue, result);
        }
    }
}