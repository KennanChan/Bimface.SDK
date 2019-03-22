using Bimface.SDK.Entities.Parameters.Data.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileFloorMappingsRequest : BimfaceDataApiRequest
    {
        public ListFileFloorMappingsRequest(ListFileFloorMappingsParameter parameter, string apiVersion = DefaultApiVersion)
            : base("/files/fileIdfloorsMappings", apiVersion)
        {
            AddNullableArrayQuery("fileIds", parameter.FileIds);
            AddNullableQuery("includeArea", parameter.IncludeArea);
            AddNullableQuery("includeRoom", parameter.IncludeRoom);
        }
    }
}