#region

using Bimface.SDK.Entities.Core.Requests;

#endregion

namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementPropertiesParameter : FileParameter
    {
        #region Constructors

        public ListElementPropertiesParameter(long? fileId, string elementId) : base(fileId)
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