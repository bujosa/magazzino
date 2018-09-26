using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Magazzino.Helpers.Utils
{
    public static class MD5Hasher
    {
        public static string ComputeHash (string data)
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(data)));
        }
    }
}
