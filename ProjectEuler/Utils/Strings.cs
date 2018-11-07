using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Utils
{
    public static class Strings
    {
        public static bool IsPalindrome(this string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return true;
            return s.Reversed().ToLower() == s.ToLower();
        }

        public static string Reversed(this string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
                return s;
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }
    }
}
