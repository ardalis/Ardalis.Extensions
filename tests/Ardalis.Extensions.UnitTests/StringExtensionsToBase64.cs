using Ardalis.Extensions.Strings;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsToBase64
    {
        [Theory]
        [InlineData("Hello,World")]
        public void ReturnsCorrectBase64RepresentationOfString(string input)
        {
            const string expectedValue = "SGVsbG8sV29ybGQ=";
            
            var result = input.Base64Encode();

            Assert.Equal(expectedValue, result);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
        {
            const string expectedValue = "";
            
            var result = input.Base64Encode();

            Assert.Equal(expectedValue, result);
        }
    }
}