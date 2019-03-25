using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.Compare
{
    [BimfaceAuth]
    internal abstract class BimfaceCompareDataApiRequest : BimfaceDataApiRequest
    {
        protected const string DefaultApiVersion = "v2";

        protected BimfaceCompareDataApiRequest(CompareParameter parameter, string relativePath, string apiVersion)
            : base($"/comparisons/{parameter.CompareId}".CombinePath(relativePath),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
        }
    }
}