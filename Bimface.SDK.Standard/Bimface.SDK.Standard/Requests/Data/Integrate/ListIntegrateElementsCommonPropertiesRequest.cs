#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateElementsCommonPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateElementsCommonPropertiesRequest(ListIntegrateElementsCommonPropertiesParameter parameter,
                                                            string                                         apiVersion = DefaultApiVersion)
            : base(parameter, "/commonElementProperties", apiVersion)
        {
            AddJsonBody(parameter.FileIdHashWithElementIdsList);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}