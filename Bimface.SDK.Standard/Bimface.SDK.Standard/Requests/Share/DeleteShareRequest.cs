using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Share
{
    [BimfaceAuth]
    internal class DeleteShareRequest : BimfaceApiRequest
    {
        public DeleteShareRequest(DeleteShareParameter parameter) : base(HttpMethods.Delete, "/share")
        {
            AddNullableQuery("fileId", parameter.FileId);
            AddNullableQuery("integrateId", parameter.IntegrateId);
        }
    }
}
