using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class SelectorTest
    {
        [TestMethod]
        public void Substring_IncludeStart_ExcludeEnd()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = "HERE end ";

            string result = testString.Substring("here", true, "there", false);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_IncludeStart_IncludeEnd()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = "is a test";

            string result = testString.Substring("is", true, "test", true);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_ExcludeStart_ExcludeEnd()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = " a test ";

            string result = testString.Substring("is", false, "string", false);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_ExcludeStart_IncludeEnd()
        {
            const string testString = "Start HERE end THERE.";
            const string expectedValue = " a test string";

            string result = testString.Substring("is", false, "string", true);

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
