using Xunit;
using String.Extensions.src;

namespace String.Extensions.Test.src
{
    public class SelectorTest
    {
        [Theory]
        [InlineData("Don't step on the broken glass.", "step on the ")]
        [InlineData("He didn’t step on the dentist, yet he broken anyway.", "step on the dentist, yet he ")]
        [InlineData("The quick brown fox steps over the broken dog.", "steps over the ")]
        public void Substring_TEST_IncludeStart(string testString, string expected)
        {
            string actual = testString.Substring("step", "broken", StringInclusionOptions.IncludeStart);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("She did not cheat on the test, for it was not the right thing to do.", " on the test, for it was not the right")]
        [InlineData("I love eating cheat cheese and tuna right.", " cheese and tuna right")]
        [InlineData("The cheat right the meal.", " right")]
        public void Substring_TEST_IncludeEnd(string testString, string expected)
        {
            string result = testString.Substring("cheat", "right", StringInclusionOptions.IncludeEnd);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("The waves were crashing on the shore; it was a lovely sight.", "waves were crashing on the shore")]
        [InlineData("She did waves best to help shore.", "waves best to help shore")]
        [InlineData("I'd rather be a waves shore a fish.", "waves shore")]
        public void Substring_TEST_IncludeBoth(string testString, string expected)
        {
            string result = testString.Substring("waves", "shore", StringInclusionOptions.IncludeAll);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Is the snatch safety better than the virus?", " safety better than the ")]
        [InlineData("It was then the snatch mess met virus unwitting cut.", " mess met ")]
        [InlineData("snatch the complete boyfriend really tip the virus?", " the complete boyfriend really tip the ")]
        public void Substring_TEST_IncludeNone(string testString, string expected)
        {
            string result = testString.Substring("snatch", "virus", StringInclusionOptions.IncludeNone);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("I started sweating.", "started sweating.")]
        [InlineData("Now I have to start all over again.", "start all over again.")]
        [InlineData("He was told that he'd be fired if he didn't start taking his job seriously.", "start taking his job seriously.")]
        public void Substring_TEST_Inclusive(string testString, string expected)
        {
            string result = testString.Substring("start", true);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("His true character is starting to show through.", "ing to show through.")]
        [InlineData("Export of the product will start soon.", " soon.")]
        [InlineData("I'm starting to lose my patience.", "ing to lose my patience.")]
        public void Substring_TEST_Exclusive(string testString, string expected)
        {
            string result = testString.Substring("start", false);

            Assert.Equal(expected, result);
        }
    }
}
