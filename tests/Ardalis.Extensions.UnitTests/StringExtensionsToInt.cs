using Ardalis.Extensions.Strings;
using System;
using Xunit;

namespace Ardalis.Extensions.UnitTests
{
    public class StringExtensionsToInt
    {
        [Fact]
        public void ThrowsExceptionGivenNullInput()
        {
            string input = null;
            Action action = () => input.ToInt();

            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void ThrowsExceptionGivenEmptyInput()
        {
            string input = "";
            Action action = () => input.ToInt();

            Assert.Throws<FormatException>(action);
        }

        [Fact]
        public void ThrowsExceptionGivenInputTooBig()
        {
            string input = "9999999999999999999999999999999999999";
            Action action = () => input.ToInt();

            Assert.Throws<OverflowException>(action);
        }

        [Fact]
        public void ThrowsExceptionGivenInputTooSmall()
        {
            string input = "-9999999999999999999999999999999999999";
            Action action = () => input.ToInt();

            Assert.Throws<OverflowException>(action);
        }
    }
}
