using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Extensions.Test.src
{
    [TestClass]
    public class SelectorTest
    {
        [TestMethod]
        public void Substring_IncludeStart_ExcludeEnd()
        {
            const string testString = "This is a test string";
            const string expectedValue = "is a test ";

            string result = testString.Substring("is", true, "string", false);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_IncludeStart_IncludeEnd()
        {
            const string testString = "This is a test string";
            const string expectedValue = "is a test";

            string result = testString.Substring("is", true, "test", true);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_ExcludeStart_ExcludeEnd()
        {
            const string testString = "This is a test string";
            const string expectedValue = " a test ";

            string result = testString.Substring("is", false, "string", false);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_ExcludeStart_IncludeEnd()
        {
            const string testString = "This is a test string";
            const string expectedValue = " a test string";

            string result = testString.Substring("is", false, "string", true);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_Include()
        {
            const string testString = "This is a test string";
            const string expectedValue = "is a test string";

            string result = testString.Substring("is", true);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void Substring_Exclude()
        {
            const string testString = "This is a test string";
            const string expectedValue = " a test string";

            string result = testString.Substring("is", false);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
