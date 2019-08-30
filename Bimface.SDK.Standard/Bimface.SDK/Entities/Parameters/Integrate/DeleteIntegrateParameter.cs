#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    [BimfaceApiHttpRequest(HttpMethods.Delete, "/integrate")]
    public class DeleteIntegrateParameter : IntegrateParameter
    {
        #region Constructors

        public DeleteIntegrateParameter(long integrateId) : base(integrateId)
        {
            IntegrateId = integrateId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public new long IntegrateId { get; }

        #endregion
    }
}