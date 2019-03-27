using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class LookupCompareOfflineDatabagDownloadUrlRequest : BimfaceDatabagDataApiRequest
    {
        public LookupCompareOfflineDatabagDownloadUrlRequest(LookupCompareOfflineDatabagDownloadUrlParameter parameter)
            : base(HttpMethods.Get, "/downloadUrl", "")
        {
            AddQuery("compareId", parameter.CompareId);
            AddQuery("databagVersion", parameter.DatabagVersion);
            AddQuery("type", parameter.Type);
        }
    }
}