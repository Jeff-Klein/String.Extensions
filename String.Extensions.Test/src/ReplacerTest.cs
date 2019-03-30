using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class ReplacerTest
    {
        [TestMethod]
        public void ReplaceStringConsiderCase()
        {
            const string testString = "THIS not this, THAT not that";
            const string expectedValue = "XXXX not this, THAT not XXXX";

            string result = testString.Replace(false, "XXXX", new[] { "THIS", "that" });

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ReplaceStringIgnoreCase()
        {
            const string testString = "THIS not this, THAT not that";
            const string expectedValue = "XXXX not XXXX, XXXX not XXXX";

            string result = testString.Replace(false, "XXXX", new[] { "THIS", "that" });

            Assert.AreEqual(expectedValue, result);
        }
    }
}
