using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
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