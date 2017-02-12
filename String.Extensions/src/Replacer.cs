using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String.Extensions
{
    public static class Replacer
    {
        public static string Replace(this string str, string replacerString, params string[] toReplace)
        {
            return Replace(str, true, replacerString, toReplace);
        }

        public static string Replace(this string str, bool ignoreCase, string replacerString, params string[] toReplace)
        {
            if (ignoreCase)
                return ReplaceStringIgnoreCase(str, replacerString, toReplace);
            else
                return ReplaceStringConsiderCase(str, replacerString, toReplace);
        }

        private static string ReplaceStringConsiderCase(this string value, string replacerString, string[] toReplace)
        {
            foreach (var item in toReplace)
                value = value.Replace(item, replacerString);

            return value;
        }

        private static string ReplaceStringIgnoreCase(this string value, string replacerString, string[] toReplace)
        {
            foreach (var item in toReplace)
                value = Regex.Replace(value, Regex.Escape(item), replacerString, RegexOptions.IgnoreCase);

            return value;
        }
    }
}
