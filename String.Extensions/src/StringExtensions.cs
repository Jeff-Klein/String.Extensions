using System.Text.RegularExpressions;

namespace CustomExtensions
{
    public static class StringExtensions
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
        
    }
}