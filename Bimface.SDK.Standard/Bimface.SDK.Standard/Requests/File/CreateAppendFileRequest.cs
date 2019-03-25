using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class CreateAppendFileRequest : BimfaceFileRequest
    {
        #region Constructors

        public CreateAppendFileRequest(CreateAppendFileParameter parameter) : base(HttpMethods.Post, "/appendFiles")
        {
            AddQuery("name", parameter.Name);
            AddNullableQuery("length", parameter.Length);
            AddQuery("sourceId", parameter.SourceId);
        }

        #endregion
    }
}