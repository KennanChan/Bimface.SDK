#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileElementsPropertiesParameter : FileParameter
    {
        #region Constructors

        public ListFileElementsPropertiesParameter(long fileId, ElementPropertyFilterRequest request) : base(fileId)
        {
            Request = request;
        }

        #endregion

        #region Properties

        public bool? IncludeOverrides { get; set; }

        public ElementPropertyFilterRequest Request { get; }

        #endregion
    }
}