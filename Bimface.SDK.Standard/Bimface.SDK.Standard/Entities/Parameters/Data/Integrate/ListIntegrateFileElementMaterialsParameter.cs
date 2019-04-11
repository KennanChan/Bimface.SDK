#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}/materials")]
    public class ListIntegrateFileElementMaterialsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFileElementMaterialsParameter(long integrateId, string fileIdHash, string elementId) :
            base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId  = elementId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string ElementId { get; }

        [HttpPathComponent]
        public string FileIdHash { get; }

        #endregion
    }
}