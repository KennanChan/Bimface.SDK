#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Get, "/data/databag/downloadUrl")]
    public abstract class LookupOfflineDatabagDownloadUrlParameter : HttpParameter
    {
        #region Properties

        [HttpQueryComponent]
        public string DatabagVersion { get; set; }

        [HttpQueryComponent]
        public string Type { get; set; }

        #endregion
    }
}