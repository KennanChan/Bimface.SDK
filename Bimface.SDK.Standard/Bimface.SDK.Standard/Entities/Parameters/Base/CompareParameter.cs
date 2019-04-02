#region

using Bimface.SDK.Attributes;

#endregion

namespace Bimface.SDK.Entities.Parameters.Base
{
    [BimfaceAuth]
    public abstract class CompareParameter : HttpParameter
    {
        #region Constructors

        protected CompareParameter(long compareId)
        {
            CompareId = compareId;
        }

        #endregion

        #region Properties

        public long CompareId { get; }

        #endregion
    }
}