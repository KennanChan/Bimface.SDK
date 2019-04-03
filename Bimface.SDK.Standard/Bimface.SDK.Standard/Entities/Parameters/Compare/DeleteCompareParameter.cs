#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    [BimfaceApiHttpRequest(HttpMethods.Delete, "/compare", "v2")]
    public class DeleteCompareParameter : CompareParameter
    {
        #region Constructors

        public DeleteCompareParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}