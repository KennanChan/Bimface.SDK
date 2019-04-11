#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Put, "/files/{fileId}/offlineDatabag")]
    public class CreateFileOfflineDatabagParameter : FileParameter
    {
        #region Constructors

        public CreateFileOfflineDatabagParameter(long fileId, string callback, DatabagDerivativeRequest request) :
            base(fileId)
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