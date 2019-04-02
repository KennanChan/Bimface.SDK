#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    [BimfaceApiHttpRequest(HttpMethods.Get, "/share")]
    public class LookupShareParameter : HttpParameter
    {
        #region Properties

        [HttpQueryComponent(Alias = "fileId")]
        public long? FileId { get; set; }

        [HttpQueryComponent(Alias = "integrateId")]
        public long? IntegrateId { get; set; }

        [HttpQueryComponent(Alias = "token")]
        public string Password { get; set; }

        #endregion
    }
}