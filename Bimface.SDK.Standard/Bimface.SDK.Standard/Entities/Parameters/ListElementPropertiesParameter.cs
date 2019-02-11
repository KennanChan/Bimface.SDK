using Bimface.SDK.Entities.Core.Requests;

namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementPropertiesParameter : FileParameter
    {
        #region Constructors

        public ListElementPropertiesParameter(long? fileId, ElementPropertyFilterRequest filter) : base(fileId)
        {
            FilterRequest = filter;
        }

        #endregion

        #region Properties

        public ElementPropertyFilterRequest FilterRequest { get; }

        #endregion
    }
}