using Bimface.SDK.Entities.Parameters.Data.Compare;

namespace Bimface.SDK.Requests.Data.Compare
{
    internal class ListCompareDiffRequest : BimfaceCompareDataApiRequest
    {
        #region Constructors

        public ListCompareDiffRequest(ListCompareDiffParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/diff", apiVersion)
        {
            AddQuery("elementName", parameter.ElementName);
            AddQuery("family", parameter.Family);
            AddNullableQuery("page", parameter.Page);
            AddNullableQuery("pageSize", parameter.PageSize);
        }

        #endregion
    }
}