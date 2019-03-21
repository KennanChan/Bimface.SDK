using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    [HttpJsonMime]
    internal class LookupFileCategoryTreeRequest : BimfaceFileDataApiRequest
    {
        public LookupFileCategoryTreeRequest(LookupFileCategoryTreeParameter parameter, string version = "v2")
            : base(parameter, "/tree", version)
        {
            AddQuery("treeType", parameter.TreeType);
            AddQuery("v", parameter.V);
            AddJsonBody(parameter.FileTreeRequest);
        }
    }
}
