using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class ReplacerTest
    {
        [TestMethod]
        public void ReplaceStringConsiderCase()
        {
            const string expectedValue = "4/PNEUMXNXULTRAMXCRXXCXPXCXXLXCXVXLCANXCXNXXXXX-1_()";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.Replace(false, "X", "O", "S", "I");

            Assert.AreEqual(expectedValue, stringTested);
        }

        [TestMethod]
        public void ReplaceStringIgnoreCase()
        {
            const string expectedValue = "4/PNEUMxNxULTRAMxCRxxCxPxCxxLxCxVxLCANxCxNxxxxx-1_()";

            var stringTested = "4/PNEUMONOULTRAMICROSCOPICSILICOVOLCANOCONIOSIS-1_()";
            stringTested = stringTested.Replace("x", "o", "s", "i");

            Assert.AreEqual(expectedValue, stringTested);
        }
    }
}
