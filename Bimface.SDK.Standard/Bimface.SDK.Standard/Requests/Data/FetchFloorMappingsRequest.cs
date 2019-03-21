using Bimface.SDK.Entities.Parameters.Data;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data
{
    internal class FetchFloorMappingsRequest : BimfaceDataApiRequest
    {
        public FetchFloorMappingsRequest(FetchFloorMappingsParameter parameter, string version = "v2") : base("/files/fileIdfloorsMappings", version)
        {
            AddNullableArrayQuery("fileIds", parameter.FileIds);
            AddNullableQuery("includeArea", parameter.IncludeArea);
            AddNullableQuery("includeRoom", parameter.IncludeRoom);
        }
    }
}