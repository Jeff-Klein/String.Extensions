using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String.Extensions
{
    public static class Remover
    {
        /// <summary>
        /// Removes multiple elements.
        /// </summary>
        /// <param name="toRemove">List of values to be removed.</param>
        public static string Remove(this string str, params string[] toRemove)
        {
            return RemoveStringConsiderCase(str, toRemove);
        }

        /// <summary>
        /// Replaces multiple elements with one same element specified. Case will be considered.
        /// </summary>
        /// <param name="ignoreCase">Ignore the case of the value to be removed.</param>
        /// <param name="toRemove">List of values to be removed.</param>
        public static string Remove(this string str, bool ignoreCase, params string[] toRemove)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, toRemove);
            else
                return RemoveStringConsiderCase(str, toRemove);
        }

        private static string RemoveStringConsiderCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = value.Replace(item, string.Empty);

            return value;
        }

        private static string RemoveStringIgnoreCase(this string value, string[] toRemove)
        {
            foreach (var item in toRemove)
                value = Regex.Replace(value, Regex.Escape(item), string.Empty, RegexOptions.IgnoreCase);

            return value;
        }

        /// <summary>
        /// Removes all numbers, keeping alphabetical letters and special characters.
        /// </summary>
        public static string RemoveAllNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Removes all special characters, keeping alphabetical letters and numbers.
        /// </summary>
        public static string RemoveAllSpecialCharacters(this string originalString)
        {
            return Regex.Replace(originalString, "[^0-9A-Za-z]+", string.Empty);
        }

        /// <summary>
        /// Removes all alphabetical letters, keeping special characters and numbers.
        /// </summary>
        public static string RemoveAllAlphabeticalLetters(this string originalString)
        {
            return Regex.Replace(originalString, "[A-Za-z]", string.Empty);
        }
    }
}
