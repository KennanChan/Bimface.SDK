#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}")]
    public class ListIntegrateFileElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFileElementPropertiesParameter(long integrateId, string fileIdHash, string elementId) :
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

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}