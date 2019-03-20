using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class ListFilesRequest : BimfaceFileRequest
    {
        public ListFilesRequest(ListFilesParameter parameter) : base("/files")
        {
            AddDateQuery("endTime", parameter.EndTime);
            AddNullableQuery("offset", parameter.Offset);
            AddNullableQuery("rows", parameter.Rows);
            AddQuery("scope", parameter.Scope);
            AddDateQuery("startTime", parameter.StartTime);
            AddQuery("status", parameter.Status);
            AddQuery("suffix", parameter.Suffix);
        }
    }
}