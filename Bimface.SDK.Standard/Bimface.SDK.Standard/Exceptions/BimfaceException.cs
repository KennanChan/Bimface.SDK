using System;

namespace Bimface.SDK.Exceptions
{
    public class BimfaceException : Exception
    {
        public string Code { get; }

        public BimfaceException(string code, string message) : base(message)
        {
            Code = code;
        }
    }
}