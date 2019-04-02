using System;
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
        /// <returns></returns>
        public static string Replace(this string str, bool ignoreCase, string newString, string[] oldStrings)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, newString, oldStrings);
            else
                return ReplaceStringConsiderCase(str, newString, oldStrings);
        }

        /// <summary>
        /// Retrieves the substring located between two given strings from this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="includeStartString">A boolean indicating whether the substring should include the given startString.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="includeEndString">A boolean indicating whether the substring should include the given endString.</param>
        /// <returns>A string representing the part of the original string, located between the startString and endString.</returns>
        public static string Substring(this string str, string startString, bool includeStartString, string endString, bool includeEndString)
        {
            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!includeStartString);
            int endStringIndex = str.IndexOf(endString) + endString.Length * Convert.ToInt32(includeEndString);

            return str.Substring(startStringIndex, endStringIndex);
        }

        /// <summary>
        /// Retrieves the substring starting from a given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="includeStartString">A boolean indicating whether the substring should include the given startString.</param>
        /// <returns>A string representing the part of the original string, located from startString to the end of the original instance.</returns>
        public static string Substring(this string str, string startString, bool inclusive)
        {
            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex);
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
