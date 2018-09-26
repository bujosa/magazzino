using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Magazzino.Helpers.Utils
{
    public static class EnumUtil<T> where T : struct, IConvertible
    {
        public static List<T> ToList()
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an Enum Type");
            }

            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }

        public static string GetDescriptionByValue(int value)
        {
            return Enum.GetName(typeof(T), value);
        }

        public static string GetValueByDescription(string description)
        {
            return Enum.Parse(typeof(T), description).ToString();
        }
    }
}
