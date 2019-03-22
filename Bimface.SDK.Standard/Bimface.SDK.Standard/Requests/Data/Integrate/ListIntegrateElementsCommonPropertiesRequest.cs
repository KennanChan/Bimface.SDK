using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateElementsCommonPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        public ListIntegrateElementsCommonPropertiesRequest(ListIntegrateElementsCommonPropertiesParameter parameter,
                                                            string                                         apiVersion = DefaultApiVersion)
            : base(parameter, "/commonElementProperties", apiVersion)
        {
            AddJsonBody(parameter.FileIdHashWithElementIdsList);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}