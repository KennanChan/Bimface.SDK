#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/elements", Method = HttpMethods.Post)]
    public class ListFileElementsPropertiesParameter : FileParameter
    {
        #region Constructors

        public ListFileElementsPropertiesParameter(long fileId, ElementPropertyFilterRequest request) : base(fileId)
        {
            Request = request;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        [HttpBodyComponent]
        public ElementPropertyFilterRequest Request { get; }

        #endregion
    }
}