#region

using System;

#endregion

namespace Bimface.SDK.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BimfaceParameterHandlerAttribute : Attribute
    {
        #region Constructors

        public BimfaceParameterHandlerAttribute(Type type)
        {
            Type = type;
        }

        #endregion

        #region Properties

        public Type Type { get; }

        #endregion
    }
}