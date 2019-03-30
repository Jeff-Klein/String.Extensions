using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class KeeperTest
    {
        [TestMethod]
        public void RemoveAllNumbersTest()
        {
            const string expectedValue = "21989";

            var stringTested = "February 2th, 1989";
            stringTested = stringTested.KeepOnlyNumbers();

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void KeepAllSpecialCharactersTest()
        {
            const string expectedValue = "/-_()";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.KeepAllSpecialCharacters();

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void KeepOnlyAlphabeticalLettersTest()
        {
            const string expectedValue = "PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.KeepOnlyAlphabeticalLetters();

            Assert.AreEqual(expectedValue, stringTested);
        }
    }
}
