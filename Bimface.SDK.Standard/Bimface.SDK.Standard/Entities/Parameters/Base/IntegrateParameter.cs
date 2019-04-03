#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Base
{
    [BimfaceAuth]
    public abstract class IntegrateParameter : HttpParameter
    {
        #region Constructors

        protected IntegrateParameter(long integrateId)
        {
            IntegrateId = integrateId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public long IntegrateId { get; }

        #endregion
    }
}