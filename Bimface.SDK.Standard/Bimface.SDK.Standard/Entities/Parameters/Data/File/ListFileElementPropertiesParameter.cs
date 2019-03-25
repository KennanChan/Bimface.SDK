#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileElementPropertiesParameter : FileParameter
    {
        #region Constructors

        public ListFileElementPropertiesParameter(long fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}