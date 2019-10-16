using System.Text.RegularExpressions;

namespace String.Extensions
{
    public static class Remover
    {
        /// <summary>
        /// Removes all instances of all of the given string array elements, case-insensitive.
        /// </summary>
        /// <param name="toRemove">Array of values to be removed.</param>
        public static string Remove(this string str, params string[] removeStrings)
        {
            return RemoveStringConsiderCase(str, removeStrings);
        }

        /// <summary>
        /// Removes all instances of all of the given string array elements. Case-sensitivity can be specified.
        /// </summary>
        /// <param name="ignoreCase">Boolean value indicating if the case of the value to be removed should be ignored.</param>
        /// <param name="removeStrings">Array of values to be removed.</param>
        public static string Remove(this string str, bool ignoreCase, params string[] removeStrings)
        {
            if (ignoreCase)
                return RemoveStringIgnoreCase(str, removeStrings);
            else
                return RemoveStringConsiderCase(str, removeStrings);
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
        /// Removes all numbers, keeping letters and special characters.
        /// </summary>
        public static string RemoveNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Removes all special characters, keeping letters and numbers.
        /// </summary>
        public static string RemoveSpecialCharacters(this string originalString)
        {
            return Regex.Replace(originalString, "[^0-9A-Za-z]+", string.Empty);
        }

        /// <summary>
        /// Removes all letters, keeping special characters and numbers.
        /// </summary>
        public static string RemoveLetters(this string originalString)
        {
            return Regex.Replace(originalString, "[A-Za-z]", string.Empty);
        }
    }
}
