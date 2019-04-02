using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Share
{
    [BimfaceAuth]
    internal class LookupShareRequest : BimfaceApiRequest
    {
        public LookupShareRequest(LookupShareParameter parameter) : base(HttpMethods.Get, "/share")
        {
            AddNullableQuery("fileId", parameter.FileId);
            AddNullableQuery("integrateId", parameter.IntegrateId);
            AddQuery("token", parameter.Password);
        }
    }
}