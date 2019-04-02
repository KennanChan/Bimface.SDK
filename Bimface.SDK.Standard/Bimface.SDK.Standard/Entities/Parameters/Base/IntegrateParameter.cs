#region

using Bimface.SDK.Attributes;

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

        public long IntegrateId { get; }

        #endregion
    }
}