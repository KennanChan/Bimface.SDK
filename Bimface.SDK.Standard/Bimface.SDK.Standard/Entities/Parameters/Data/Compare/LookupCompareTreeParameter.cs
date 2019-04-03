#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceDataApiHttpRequest("/comparisons/{comparisonId}/tree")]
    public class LookupCompareTreeParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareTreeParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}