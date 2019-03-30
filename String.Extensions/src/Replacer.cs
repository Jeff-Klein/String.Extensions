using System.Text.RegularExpressions;

namespace String.Extensions
{
    public static class Replacer
    {
        /// <summary>
        /// Replaces multiple strings with the specified string.
        /// </summary>
        /// <param name="ignoreCase">Whether the replacement should be case sensetive or not.</param>
        /// <param name="newString">The string to replace all occurances of oldStrings</param>
        /// <param name="oldStrings">Array of strings to be replaced.</param>
        public static string Replace(this string str, bool ignoreCase, string newString, string[] oldStrings)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, newString, oldStrings);
            else
                return ReplaceStringConsiderCase(str, newString, oldStrings);
        }

        private static string ReplaceStringConsiderCase(this string value, string newString, string[] oldStrings)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.None);

            return value;
        }

        private static string ReplaceStringIgnoreCase(this string value, string newString, string[] oldStrings)
        {
            foreach (var item in oldStrings)
                value = Regex.Replace(value, Regex.Escape(item), newString, RegexOptions.IgnoreCase);

            return value;
        }
    }
}
