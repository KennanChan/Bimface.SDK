using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    [HttpJsonMime]
    internal class LookupFileCategoryTreeRequest : BimfaceFileDataApiRequest
    {
        public LookupFileCategoryTreeRequest(LookupFileCategoryTreeParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/tree", apiVersion)
        {
            AddQuery("treeType", parameter.TreeType);
            AddQuery("v", parameter.V);
            AddJsonBody(parameter.FileTreeRequest);
        }
    }
}
