#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateElementsPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateElementsPropertiesRequest(ListIntegrateElementsPropertiesParameter parameter,
                                                      string                                   apiVersion = DefaultApiVersion)
            : base(parameter, "/elements", apiVersion)
        {
            AddJsonBody(parameter.FileIdHashWithElementIdsList);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}