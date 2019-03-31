#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class LookupFileRequest : BimfaceFileRequest
    {
        #region Constructors

        public LookupFileRequest(LookupFileParameter parameter) : base(HttpMethods.Get, "/metadata")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }

        #endregion
    }
}