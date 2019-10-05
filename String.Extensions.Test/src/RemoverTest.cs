using Xunit;
using String.Extensions;

namespace UnitTestProject1
{
    public class RemoverTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void RemoveStringConsiderCase(string testString, string expected)
        {
            const string expectedValue = "pneumnultramicrcpicilicvlcancnii";

            var stringTested = "4/pneumonoultramicroscopicsilicovolcanoconiosis-1_()";
            stringTested = stringTested.Remove("(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.Equal(expectedValue, stringTested);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void RemoveStringIgnoreCaseTest(string testString, string expected)
        {
            const string expectedValue = "PNEUMNULTRAMICRCPICILICVLCANCNII";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.Remove(true, "(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.Equal(expectedValue, stringTested);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void RemoveAllNumbersTest(string testString, string expected)
        {
            const string expectedValue = "February th, ";

            var stringTested = "February 2th, 1989";
            stringTested = stringTested.RemoveAllNumbers();

            Assert.Equal(expectedValue, stringTested);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void RemoveAllSpecialCharactersTest(string testString, string expected)
        {
            const string expectedValue = "711worksweekendsSatandSun";

            var stringTested = "7-11 works_weekends (Sat and Sun)";
            stringTested = stringTested.RemoveAllSpecialCharacters();

            Assert.Equal(expectedValue, stringTested);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "")]
        [InlineData("", "")]
        public void RemoveAllAlphabeticalLettersTest(string testString, string expected)
        {
            const string expectedValue = "__ - ()";

            var stringTested = "_asd_ a-b (owo)";
            stringTested = stringTested.RemoveAllAlphabeticalLetters();

            Assert.Equal(expectedValue, stringTested);
        }
    }
}
