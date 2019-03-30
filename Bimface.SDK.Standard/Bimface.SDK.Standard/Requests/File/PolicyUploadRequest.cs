#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class PolicyUploadRequest : BimfaceFileRequest
    {
        #region Constructors

        public PolicyUploadRequest(PolicyUploadParameter parameter) : base(HttpMethods.Get, "/upload/policy")
        {
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
        }

        #endregion
    }
}