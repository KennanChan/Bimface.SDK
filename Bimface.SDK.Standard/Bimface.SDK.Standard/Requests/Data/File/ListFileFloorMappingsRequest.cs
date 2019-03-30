#region

using Bimface.SDK.Entities.Parameters.Data.File;

#endregion

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileFloorMappingsRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileFloorMappingsRequest(ListFileFloorMappingsParameter parameter,
                                            string                         apiVersion = DefaultApiVersion)
            : base(parameter, $"/files/{parameter.FileId}/floorsMappings", apiVersion)
        {
            AddNullableArrayQuery("fileIds", parameter.FileIds);
            AddNullableQuery("includeArea", parameter.IncludeArea);
            AddNullableQuery("includeRoom", parameter.IncludeRoom);
        }

        #endregion
    }
}