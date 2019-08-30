#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceDataApiHttpRequest("/comparisons/{comparisonId}/tree")]
    public class LookupCompareCategoryTreeParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareCategoryTreeParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}