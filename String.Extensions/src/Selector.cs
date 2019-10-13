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
        /// Retrieves a substring from this instance that is located between given start and end strings.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring to be extracted.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="stringInclusionOptions">A StringInclusionOptions enum, indicating whether startString and/or endString should be included in the result.</param>
        /// <returns>A string representing the part of the original string, located between the startString and endString.</returns>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            // These are precaution calls, meant to throw an "ArgumentOutOfRangeException" exception if needed.
            str.Substring(str.IndexOf(startString));
            str.Substring(str.IndexOf(endString));

            int startStringIndex = str.IndexOf(startString);
            int endStringIndex = str.IndexOf(endString);

            switch (stringInclusionOptions)
            {
                case StringInclusionOptions.IncludeNone:
                    startStringIndex += startString.Length;
                    break;
                case StringInclusionOptions.IncludeStart:
                    break;
                case StringInclusionOptions.IncludeEnd:
                    startStringIndex += startString.Length;
                    endStringIndex += endString.Length;
                    break;
                case StringInclusionOptions.IncludeAll:
                    endStringIndex += endString.Length;
                    break;
            }

            int selectLength = endStringIndex - startStringIndex;

            return str.Substring(startStringIndex, selectLength);
        }

        /// <summary>
        /// Retrieves the substring starting from the first instance of
        /// the given string to the end of this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given startString.</param>
        /// <returns>A string representing the part of the original string, located from startString to the end of the original instance.</returns>
        public static string Substring(this string str, string startString, bool inclusive)
        {
            // This is a precaution call, meant to throw an "ArgumentOutOfRangeException" exception if needed.
            str.Substring(str.IndexOf(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first
        /// occurence of a specified string position and has a specified length.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="length">The number of characters to return.</param>
        /// <param name="inclusive">A boolean indicating whether the substring should include the given startString.</param>
        /// <returns>
        /// A string that is equivalent to the substring of length "length" that begins at
        /// the first instance of "startString" in this string instance
        /// </returns>
        public static string Substring(this string str, string startString, int length, bool inclusive)
        {
            // This is a precaution call, meant to throw an "ArgumentOutOfRangeException" exception if needed.
            str.Substring(str.IndexOf(startString));

            int startStringIndex = str.IndexOf(startString) + startString.Length * Convert.ToInt32(!inclusive);

            return str.Substring(startStringIndex, length);
        }
    }
}
