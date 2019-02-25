using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extensions.Extensions
{
    public static class StringExtensions
    {
        public static string Captilise(this string input)
        {
            if (input.Length > 0)
            {
                char[] array = input.ToLower().ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return input;
        }

        public static string RemoveWhiteSpaces(this string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }

        public static int WordCount(this string input)
        {
            if (input.Trim().Length == 0)
                return 0;
            return Regex.Split(input, @"\W+").Length;
        }

        public static string TrimAndReduce(this string input)
        {
            return Regex.Replace(input, @"\s+", " ").Trim();
        }

        public static string ToTitleCase(this string input)
        {
            var strings = input.Split(' ');
            var ret = string.Concat(strings.Select(a => a = a.Captilise() + " "));
            return ret.Substring(0, ret.Length - 1);
        }

    }
}
