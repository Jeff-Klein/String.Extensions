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

        }
    }
}
