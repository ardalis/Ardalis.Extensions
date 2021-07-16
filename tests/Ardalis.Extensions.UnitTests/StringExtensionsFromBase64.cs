using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsFromBase64
    {
        [Theory]
        [InlineData("SGVsbG8sV29ybGQ=")]
        public void ReturnsCorrectBase64RepresentationOfString(string input)
        {
            const string expectedValue = "Hello,World";
            
            var result = input.DecodeBase64String();

            Assert.Equal(expectedValue, result);
        }
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ReturnsEmptyStringWhenCalledOnNullOrEmpty(string input)
        {
            const string expectedValue = "";
            
            var result = input.DecodeBase64String();

            Assert.Equal(expectedValue, result);
        }
    }
}