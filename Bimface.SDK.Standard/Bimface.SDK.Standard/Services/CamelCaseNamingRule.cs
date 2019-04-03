#region

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    internal class CamelCaseNamingRule : INamingRule
    {
        #region Interface Implementations

        public string GetName()
        {
            return "camel";
        }

        public string Naming(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return name;
            return Join(Tokenize(name));
        }

        #endregion

        #region Others

        /// <summary>
        ///     Join the tokens following camel casing rule
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        private string Join(string[] tokens)
        {
            if (tokens.Length == 0) return string.Empty;
            var builder = new StringBuilder();
            builder.Append(tokens[0].ToLower());
            for (var i = 1; i < tokens.Length; i++)
            {
                builder.Append(tokens[i].Substring(0, 1).ToUpper()).Append(tokens[i].Substring(1));
            }

            return builder.ToString();
        }

        /// <summary>
        ///     Split the string into tokens
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        private string[] Tokenize(string @string)
        {
            return @string
                   //fist split the string by special chars
                  .Split(' ', '-', '.', ',')
                  .SelectMany(s =>
                           //then split each word by capital letter as starting letter
                           Regex.Replace(s, "([A-Z])", " $1", RegexOptions.Compiled).Trim().Split(' '))
                  .ToArray();
        }

        #endregion
    }
}