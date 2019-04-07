using String.Extensions.src;
using System;

namespace String.Extensions
{
    public static class Selector
    {
        /// <summary>
        /// Retrieves the substring located between two given strings from this instance.
        /// </summary>
        /// <param name="str">The instance from which to extract a substring.</param>
        /// <param name="startString">The string which marks the start of the substring.</param>
        /// <param name="includeStartString">A boolean indicating whether the substring should include the given startString.</param>
        /// <param name="endString">The string which marks the end of the substring.</param>
        /// <param name="includeEndString">A boolean indicating whether the substring should include the given endString.</param>
        /// <returns>A string representing the part of the original string, located between the startString and endString.</returns>
        public static string Substring(this string str, string startString, string endString, StringInclusionOptions stringInclusionOptions)
        {
            int startStringIndex = 0;
            int endStringIndex = 0;

            switch (stringInclusionOptions)
            {
                case StringInclusionOptions.IncludeNone:
                    startStringIndex = str.IndexOf(startString) + startString.Length;
                    endStringIndex = str.IndexOf(endString);
                    break;
                case StringInclusionOptions.IncludeStart:
                    startStringIndex = str.IndexOf(startString);
                    endStringIndex = str.IndexOf(endString);
                    break;
                case StringInclusionOptions.IncludeEnd:
                    startStringIndex = str.IndexOf(startString);
                    endStringIndex = str.IndexOf(endString) + endString.Length;
                    break;
                case StringInclusionOptions.IncludeBoth:
                    startStringIndex = str.IndexOf(startString);
                    endStringIndex = str.IndexOf(endString) + endString.Length;
                    break;
            }

            return str.Substring(startStringIndex, endStringIndex);
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
