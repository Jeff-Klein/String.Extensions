using System.Linq;
using System.Text.RegularExpressions;

namespace String.Extensions
{

    public static class Keeper
    {
        /// <summary>
        /// Keeps all numbers, removing letters and special characters.
        /// </summary>
        public static string KeepOnlyNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[^\d]", "");
        }

        /// <summary>
        /// Keeps all special characters, removing letters and numbers.
        /// </summary>
        public static string KeepOnlySpecialCharacters(this string originalString)
        {
            string specialCharacters = string.Empty;

            foreach (var item in originalString.Where(x => !char.IsLetterOrDigit(x)).GroupBy(x => x))
                specialCharacters = specialCharacters + item.Key;

            return specialCharacters;
        }

        /// <summary>
        /// Keeps all alphabetical letters, removing special characters and numbers.
        /// </summary>
        public static string KeepOnlyLetters(this string originalString)
        {        
            return Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
        }
    }
}
