using Xunit;

namespace String.Extensions.Test.src
{
    public class ReplacerTest
    {
        [Theory]
        [InlineData("t34ROgYYYY2p2TlJ4JYsa2yyyylJts0hLujF72", "t34ROgYYYY2p2TlJ4JYsa2XXXXlJts0hLujF72")]
        [InlineData("SpyyyytLUHHxYYYYJnPltTikZZZZl8FuOOzzzzc091F2Yk", "SpXXXXtLUHHxYYYYJnPltTikXXXXl8FuOOzzzzc091F2Yk")]
        [InlineData("svAZzZzEYqjq8YyYy0hVKuFRyyyyl2ry4eZZZZauLCe6V", "svAZzZzEYqjq8YyYy0hVKuFRXXXXl2ry4eXXXXauLCe6V")]
        public void ReplaceString_Test_ConsiderCase(string testString, string expected)
        {
            string actual = testString.Replace(false, "XXXX", new[] { "yyyy", "ZZZZ" });

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("t34ROgYYYY2p2TlJ4JYsa2yyyylJts0hLujF72", "t34ROgXXXX2p2TlJ4JYsa2XXXXlJts0hLujF72")]
        [InlineData("SpyyyytLUHHxYYYYJnPltTikZZZZl8FuOOzzzzc091F2Yk", "SpXXXXtLUHHxXXXXJnPltTikXXXXl8FuOOXXXXc091F2Yk")]
        [InlineData("svAZzZzEYqjq8YyYy0hVKuFRyyyyl2ry4eZZZZauLCe6V", "svAXXXXEYqjq8XXXX0hVKuFRXXXXl2ry4eXXXXauLCe6V")]
        public void ReplaceString_Test_IgnoreCase(string testString, string expected)
        {
            string actual = testString.Replace(true, "XXXX", new[] { "ZZZZ", "yyyy" });

            Assert.Equal(expected, actual);
        }
    }
}
