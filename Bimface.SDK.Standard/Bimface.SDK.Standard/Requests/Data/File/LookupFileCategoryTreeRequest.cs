#region

using Bimface.SDK.Entities.Parameters.Data.File;

#endregion

namespace Bimface.SDK.Requests.Data.File
{
    internal class LookupFileCategoryTreeRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public LookupFileCategoryTreeRequest(LookupFileCategoryTreeParameter parameter,
                                             string                          apiVersion = DefaultApiVersion)
            : base(parameter, "/tree", apiVersion)
        {
            AddQuery("treeType", parameter.TreeType);
            AddQuery("v", parameter.V);
            AddJsonBody(parameter.FileTreeRequest);
        }

        #endregion
    }
}