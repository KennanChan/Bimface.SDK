using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileLinksRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileLinksRequest(ListFileLinksParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/links", apiVersion)
        {
        }

        #endregion
    }
}