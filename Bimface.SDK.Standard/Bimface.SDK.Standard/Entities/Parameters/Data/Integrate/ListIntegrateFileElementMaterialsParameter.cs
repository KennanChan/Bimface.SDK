#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
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

        public string ElementId { get; }

        public string FileIdHash { get; }

        #endregion
    }
}