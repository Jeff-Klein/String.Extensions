using Xunit;

namespace String.Extensions.Test.src
{
    public class RemoverTest
    {
        [Theory]
        [InlineData("Lorem lorem IPSUM ipsum", "Lorem   ipsum")]
        [InlineData("lorem LORem ipSUM IPSUM", " LORem ipSUM ")]
        [InlineData("lorem ipsum IPSUM", " ipsum ")]
        public void RemoveString_Test_ConsiderCase(string testString, string expected)
        {
            string actual = testString.Remove("lorem", "IPSUM");

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Lorem lorem IPSUM ipsum", "   ")]
        [InlineData("lorem LORem ipSUM IPSUM", "   ")]
        [InlineData("lorem ipsum IPSUM", "  ")]
        public void RemoveString_Test_IgnoreCase(string testString, string expected)
        {
            string actual = testString.Remove(true, "lorem", "IPSUM");

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("b2HGLTxiVJz0cxWacceZ", "bHGLTxiVJzcxWacceZ")]
        [InlineData("S1Rsf3jsE2IPKhIML5kN", "SRsfjsEIPKhIMLkN")]
        [InlineData("xqyao0g2EwQmweZUqy6l", "xqyaogEwQmweZUqyl")]
        public void RemoveNumbers_Test(string testString, string expected)
        {
            string actual = testString.RemoveNumbers();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"5riD+p-AvsnZImA@i[(r", @"5riDpAvsnZImAir")]
        [InlineData(@"qnxON$cEX\=i?]3s3MyB", @"qnxONcEXi3s3MyB")]
        [InlineData(@"^{b,H:b{ft^3TU<PZJGd", @"bHbft3TUPZJGd")]
        public void RemoveSpecialCharacters_Test(string testString, string expected)
        {
            string actual = testString.RemoveSpecialCharacters();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"rMhj5(VirYg<rS7lWuGZ", @"5(<7")]
        [InlineData(@"gNa/*+Kd($@k+$%8Fj/I", @"/*+($@+$%8/")]
        [InlineData(@"bJcnmhy7<9-h%]wk[dTc", @"7<9-%][")]
        public void RemoveLetters_Test(string testString, string expected)
        {
            string actual = testString.RemoveLetters();

            Assert.Equal(expected, actual);
        }
    }
}
