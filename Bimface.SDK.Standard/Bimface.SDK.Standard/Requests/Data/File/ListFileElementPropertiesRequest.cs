using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileElementPropertiesRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileElementPropertiesRequest(ListFileElementPropertiesParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/elements/{parameter.ElementId}", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}