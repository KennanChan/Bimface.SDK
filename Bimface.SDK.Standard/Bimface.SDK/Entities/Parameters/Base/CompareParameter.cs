#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;

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

        [HttpPathComponent]
        public long CompareId { get; }

        #endregion
    }
}