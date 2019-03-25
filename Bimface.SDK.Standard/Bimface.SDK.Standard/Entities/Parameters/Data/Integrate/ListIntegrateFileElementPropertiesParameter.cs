using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFileElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFileElementPropertiesParameter(long integrateId, string fileIdHash, string elementId) :
            base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        public string FileIdHash { get; }
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}