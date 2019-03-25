using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFileElementPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateFileElementPropertiesRequest(ListIntegrateFileElementPropertiesParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/files/{parameter.FileIdHash}/elements/{parameter.ElementId}", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}