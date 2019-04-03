#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    [BimfaceApiHttpRequest(HttpMethods.Post, "/compare", "v2")]
    public class CreateCompareParameter : HttpParameter
    {
        public CreateCompareParameter(CompareRequest request)
        {
            Request = request;
        }

        #region Properties

        [HttpBodyComponent]
        public CompareRequest Request { get; set; }

        #endregion
    }
}