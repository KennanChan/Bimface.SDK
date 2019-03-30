#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Integrate
{
    internal class LookupIntegrateOfflineDatabagDownloadUrlRequest : BimfaceDatabagDataApiRequest
    {
        #region Constructors

        public LookupIntegrateOfflineDatabagDownloadUrlRequest(LookupIntegrateOfflineDatabagDownloadUrlParameter parameter)
            : base(HttpMethods.Get, "/downloadUrl", "")
        {
            AddQuery("integrateId", parameter.IntegrateId);
            AddQuery("databagVersion", parameter.DatabagVersion);
            AddQuery("type", parameter.Type);
        }

        #endregion
    }
}