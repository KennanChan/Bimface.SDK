#region

using System;

#endregion

namespace Bimface.SDK.Exceptions
{
    public class BimfaceException : Exception
    {
        #region Constructors

        public BimfaceException(string code, string message) : base(message)
        {
            Code = code;
        }

        #endregion

        #region Properties

        public string Code { get; }

        #endregion
    }
}