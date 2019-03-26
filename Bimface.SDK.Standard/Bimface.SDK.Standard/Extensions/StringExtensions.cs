using System;
using System.IO;
using System.Text;

namespace Bimface.SDK.Extensions
{
    public static class StringExtensions
    {
        public static string Base64Decode(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetString(Convert.FromBase64String(s));
        }

        public static string Base64Encode(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return Convert.ToBase64String(encoding.GetBytes(s));
        }

        public static string CombinePath(this string s, string another)
        {
            const string separator = "/";
            s       = s.EndsWith(separator) ? s.Substring(0, s.Length - 1) : s;
            another = another.StartsWith(separator) ? another : $"{separator}{another}";
            return $"{s}{another}";
        }

        public static Stream ToStream(this string s, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return encoding.GetBytes(s).ToStream();
        }
    }
}