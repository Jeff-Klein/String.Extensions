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
        public static string Remove(this string str, params string[] toRemove)
        {
            return RemoveStringConsiderCase(str, toRemove);
        }

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

        public static string RemoveAllNumbers(this string value)
        {
            return Regex.Replace(value, @"[\d-]", string.Empty);
        }

        public static string RemoveAllSpecialCharacters(this string value)
        {
            return Regex.Replace(value, "[^0-9A-Za-z]+", string.Empty);
        }
    }
}
