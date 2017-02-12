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
        public static string KeepOnlyNumbers(this string value)
        {
            return Regex.Replace(value, @"[^\d]", "");
        }
    }
}
