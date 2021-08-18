using Ardalis.Extensions.Encoding.Base64;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class ToBase64Tests
    {
        [Theory]
        [InlineData("Hello,World")]
        public void ReturnsCorrectBase64RepresentationOfString(string input)
        {
            const string expectedValue = "SGVsbG8sV29ybGQ=";
            
            var result = input.ToBase64();

            Assert.Equal(expectedValue, result);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
        {
            const string expectedValue = "";
            
            var result = input.ToBase64();

            Assert.Equal(expectedValue, result);
        }
    }
}