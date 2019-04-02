using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Share
{
    [BimfaceAuth]
    internal class CreateShareRequest : BimfaceApiRequest
    {
        public CreateShareRequest(CreateShareParameter parameter) : base(HttpMethods.Post, "/share")
        {
            AddQuery("activeHours", parameter.ActiveHours);
            AddDateQuery("expireDate", parameter.ExpireDate);
            AddNullableQuery("fileId", parameter.FileId);
            AddNullableQuery("integrateId", parameter.IntegrateId);
            AddNullableQuery("needPassword", parameter.NeedPassword);
        }
    }
}
