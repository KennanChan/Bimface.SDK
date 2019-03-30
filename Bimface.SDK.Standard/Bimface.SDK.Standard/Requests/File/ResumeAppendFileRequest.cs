using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class ResumeAppendFileRequest : BimfaceFileRequest
    {
        #region Constructors

        public ResumeAppendFileRequest(ResumeAppendFileParameter parameter) : base(HttpMethods.Post,
            $"/appendFiles/{parameter.AppendFileId}/data")
        {
            AddNullableQuery("position", parameter.Position);
        }

        #endregion
    }
}