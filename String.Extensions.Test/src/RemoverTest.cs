using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String.Extensions;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoverTest
    {
        [TestMethod]
        public void RemoveStringConsiderCase()
        {
            const string expectedValue = "pneumnultramicrcpicilicvlcancnii";

            var stringTested = "4/pneumonoultramicroscopicsilicovolcanoconiosis-1_()";
            stringTested = stringTested.Remove("(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void RemoveStringIgnoreCaseTest()
        {
            const string expectedValue = "PNEUMNULTRAMICRCPICILICVLCANCNII";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.Remove(true, "(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void RemoveAllNumbersTest()
        {
            const string expectedValue = "February th, ";

            var stringTested = "February 2th, 1989";
            stringTested = stringTested.RemoveAllNumbers();

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void RemoveAllSpecialCharactersTest()
        {
            const string expectedValue = "4PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS1";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.RemoveAllSpecialCharacters();

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void RemoveAllTextTest()
        {
            const string expectedValue = "4/-1_()";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.RemoveAllText();

            Assert.AreEqual(expectedValue, stringTested);
        }
    }
}
