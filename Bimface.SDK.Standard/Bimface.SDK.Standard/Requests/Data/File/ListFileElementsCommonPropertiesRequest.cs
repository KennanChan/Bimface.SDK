#region

using Bimface.SDK.Entities.Parameters.Data.File;

#endregion

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileElementsCommonPropertiesRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileElementsCommonPropertiesRequest(ListFileElementsPropertiesParameter parameter,
                                                       string                              apiVersion = DefaultApiVersion)
            : base(parameter, "/commonElementProperties", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}