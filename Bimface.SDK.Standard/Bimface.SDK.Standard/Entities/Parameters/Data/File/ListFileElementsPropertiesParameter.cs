#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ListFileElementsPropertiesParameter : FileParameter
    {
        public ListFileElementsPropertiesParameter(long fileId, ElementPropertyFilterRequest request) : base(fileId)
        {
            Request = request;
        }

        public ElementPropertyFilterRequest Request { get; }

        public bool? IncludeOverrides { get; set; }
    }
}