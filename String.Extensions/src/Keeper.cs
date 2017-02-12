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
        public static string KeepOnlyNumbers(this string originalString)
        {
            return Regex.Replace(originalString, @"[^\d]", "");
        }

        public static string KeepAllSpecialCharacters(this string originalString)
        {
            string specialCharacters = string.Empty;

            foreach (var item in originalString.Where(x => !char.IsLetterOrDigit(x)).GroupBy(x => x))
                specialCharacters = specialCharacters + item.Key;

            return specialCharacters;
        }

        public static string KeepOnlyAlphabeticalLetters(this string originalString)
        {        
            return Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
        }
    }
}
