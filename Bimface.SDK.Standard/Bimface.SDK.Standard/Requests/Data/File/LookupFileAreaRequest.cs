using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class LookupFileAreaRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public LookupFileAreaRequest(LookupFileAreaParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/areas/{parameter.AreaId}", apiVersion)
        {
        }

        #endregion
    }
}