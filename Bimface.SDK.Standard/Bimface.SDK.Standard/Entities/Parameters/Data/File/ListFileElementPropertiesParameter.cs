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

        public bool? IncludeOverrides { get; set; }

        public string ElementId { get; }

        #endregion
    }
}