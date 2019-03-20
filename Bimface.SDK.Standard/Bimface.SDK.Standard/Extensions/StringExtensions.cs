using System;
using System.IO;
using System.Text;

namespace Bimface.SDK.Extensions
{
    public static class StringExtensions
    {
        public static Stream ToStream(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetBytes(s).ToStream();
        }

        public static string Base64Encode(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return Convert.ToBase64String(encoding.GetBytes(s));
        }

        public static string Base64Decode(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetString(Convert.FromBase64String(s));
        }
    }
}