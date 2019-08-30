#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Put, "/comparisons/{compareId}/offlineDatabag")]
    public class CreateCompareOfflineDatabagParameter : CompareParameter
    {
        #region Constructors

        public CreateCompareOfflineDatabagParameter(long compareId, string callback, DatabagDerivativeRequest request)
            : base(compareId)
        {
            Callback = callback;
            Request  = request;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string Callback { get; }

        [HttpBodyComponent]
        public DatabagDerivativeRequest Request { get; }

        #endregion
    }
}