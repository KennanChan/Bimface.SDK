using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFileViewsRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateFileViewsRequest(ListIntegrateFileViewsParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, "/fileViews", apiVersion)
        {
            AddQuery("viewType", parameter.ViewType);
        }

        #endregion
    }
}