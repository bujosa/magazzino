using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Magazzino.Helpers.Extensions
{
    public static class StringExtensions
    {
        public static string SplitCammeCase ( this string str)
        {
            return Regex.Replace(str, "(\\B[A-Z])", "$1");
        }

    }
}
