using Microsoft.VisualStudio.TestTools.UnitTesting;
using String.Extensions.src;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class SelectorTest
    {
        [TestMethod]
        public void Substring_IncludeStart()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = "HERE end ";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeStart);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_IncludeBoth()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = "HERE end THERE";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeBoth);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_IncludeNone()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = " end ";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeNone);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_IncludeEnd()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = " end THERE";

            string result = testString.Substring("HERE", "THERE", StringInclusionOptions.IncludeEnd);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_Include()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = "is a test string";

            string result = testString.Substring("is", true);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_Exclude()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = " test string";

            string result = testString.Substring("is a", false);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
