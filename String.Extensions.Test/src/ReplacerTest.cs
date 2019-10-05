using Xunit;

namespace String.Extensions.Test.src
{
    public class ReplacerTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void ReplaceStringConsiderCase(string testString, string expected)
        {
            const string expectedValue = "XXXX not this, THAT not XXXX";

            string result = testString.Replace(false, "XXXX", new[] { "THIS", "that" });

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void ReplaceStringIgnoreCase(string testString, string expected)
        {
            const string expectedValue = "XXXX not XXXX, XXXX not XXXX";

            string result = testString.Replace(true, "XXXX", new[] { "THIS", "that" });

            Assert.Equal(expectedValue, result);
        }
    }
}
