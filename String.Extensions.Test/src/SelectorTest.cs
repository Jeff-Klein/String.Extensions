using Xunit;
using String.Extensions.src;

namespace String.Extensions.Test.src
{
    public class SelectorTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_IncludeStart(string testString, string expected)
        {
            string actual = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeStart);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_IncludeEnd(string testString, string expected)
        {
            const string expectedValue = " end THERE";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeEnd);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_IncludeBoth(string testString, string expected)
        {
            const string expectedValue = "HERE end THERE";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeAll);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_IncludeNone(string testString, string expected)
        {
            const string expectedValue = " end ";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeNone);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_Include(string testString, string expected)
        {
            const string expectedValue = "is a test string";

            string result = testString.Substring("is", true);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void Substring_Exclude(string testString, string expected)
        {
            const string expectedValue = " test string";

            string result = testString.Substring("is a", false);

            Assert.Equal(expectedValue, result);
        }
    }
}
