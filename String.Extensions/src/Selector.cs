using String.Extensions.src;
using System;

namespace String.Extensions
{
    /// <summary>
    /// Contains methods that select substrings and charaters from strings.
    /// </summary>
    public static class Selector
    {
        /// <summary>
        /// Retrieves a substring, located between given start and end strings, from this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">A StringInclusionOptions enum, indicating whether startString and/or endString should be included in the result.</param>
        /// <returns>A string representing the part of the original string, located between the startString and endString.</returns>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            int startStringIndex = str.IndexOf(startString);
            int endStringIndex = str.IndexOf(endString);
            int selectLength = str.Length - startStringIndex; // At minimum select the string from startStringIndex to end.

            switch (stringInclusionOptions)
            {
                case StringInclusionOptions.IncludeNone:
                    startStringIndex += startString.Length;
                    selectLength = startString.Length - (endStringIndex - endString.Length);
                    break;
                case StringInclusionOptions.IncludeStart:
                    selectLength = endString.Length;
                    break;
                case StringInclusionOptions.IncludeEnd:
                    startStringIndex += startString.Length;
                    selectLength = startString.Length;
                    break;
                case StringInclusionOptions.IncludeAll:
                    selectLength -= endStringIndex - endString.Length;
                    break;
            }

            return str.Substring(startStringIndex, selectLength);
        }

        /// <summary>
        /// Retrieves the substring starting from the given string to the end of this instance.
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startString"></param>
        /// <param name="length"></param>
        /// <param name="inclusive"></param>
        /// <returns></returns>
        public static string Substring(this string str, string startString, int length, bool inclusive)
        {
            return "";
        }
    }
}
