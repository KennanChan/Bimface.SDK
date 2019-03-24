using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFileElementMaterialsParameter : IntegrateParameter
    {
        public ListIntegrateFileElementMaterialsParameter(long integrateId, string fileIdHash, string elementId) :
            base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId = elementId;
        }

        public string FileIdHash { get; }

        public string ElementId { get; }
    }
}