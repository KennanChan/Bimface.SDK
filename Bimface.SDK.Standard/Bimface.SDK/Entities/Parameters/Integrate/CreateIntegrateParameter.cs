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
    [BimfaceApiHttpRequest(HttpMethods.Put, "/integrate")]
    public class CreateIntegrateParameter : HttpParameter
    {
        #region Constructors

        public CreateIntegrateParameter(FileIntegrateRequest request)
        {
            Request = request;
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public FileIntegrateRequest Request { get; }

        #endregion
    }
}