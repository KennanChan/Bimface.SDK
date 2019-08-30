#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Post, "/integrateDetails")]
    public class ListFileIntegrateDetailsParameter : HttpParameter
    {
        #region Constructors

        public ListFileIntegrateDetailsParameter(IntegrateQueryRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public IntegrateQueryRequest Request { get; }

        #endregion
    }
}