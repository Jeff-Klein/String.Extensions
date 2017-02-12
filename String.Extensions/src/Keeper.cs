using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String.Extensions
{
    
    public static class Keeper
    {
        /// <summary>
        /// Keeps all numbers, removing alphabetical letters and special characters.
        /// </summary>
        public static string KeepOnlyNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[^\d]", "");
        }

        /// <summary>
        /// Keeps all special characters, removing alphabetical letters and numbers.
        /// </summary>
        public static string KeepAllSpecialCharacters(this string originalString)
        {
            string specialCharacters = string.Empty;

            foreach (var item in originalString.Where(x => !char.IsLetterOrDigit(x)).GroupBy(x => x))
                specialCharacters = specialCharacters + item.Key;

            return specialCharacters;
        }

        /// <summary>
        /// Keeps all alphabetical letters, removing special characters and numbers.
        /// </summary>
        public static string KeepOnlyAlphabeticalLetters(this string originalString)
        {        
            return Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
        }
    }
}
