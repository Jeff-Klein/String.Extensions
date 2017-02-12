using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using String.Extensions;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoverTest
    {
        [TestMethod]
        public void TestLowerCase()
        {
            const string expectedValue = "pneumnultramicrcpicilicvlcancnii";

            var stringTested = "4/pneumonoultramicroscopicsilicovolcanoconiosis-1_()";
            stringTested = stringTested.Remove("(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void TestUpperCase()
        {
            const string expectedValue = "PNEUMNULTRAMICRCPICILICVLCANCNII";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.Remove(true, "(", ")", "1", "-", "/", "4", "o", "s", "_");

            Assert.AreEqual(expectedValue, stringTested);
        }

        

    }
}
