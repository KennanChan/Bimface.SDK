#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Get, "/comparisons/{compareId}/offlineDatabag")]
    public class LookupCompareOfflineDatabagParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareOfflineDatabagParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}