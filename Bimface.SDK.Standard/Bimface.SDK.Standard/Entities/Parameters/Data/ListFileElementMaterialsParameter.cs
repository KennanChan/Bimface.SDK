using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data
{
    public class ListFileElementMaterialsParameter : FileParameter
    {
        #region Constructors

        public ListFileElementMaterialsParameter(long fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        #endregion
    }
}