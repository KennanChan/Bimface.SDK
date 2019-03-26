using System;

namespace Bimface.SDK.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BimfaceParameterHandlerAttribute : Attribute
    {
        public BimfaceParameterHandlerAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
