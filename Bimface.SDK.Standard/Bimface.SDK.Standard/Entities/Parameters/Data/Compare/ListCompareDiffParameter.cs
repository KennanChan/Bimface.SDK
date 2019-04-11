#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceDataApiHttpRequest("/comparisons/{comparisonId}/diff")]
    public class ListCompareDiffParameter : CompareParameter
    {
        #region Constructors

        public ListCompareDiffParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string ElementName { get; set; }

        [HttpQueryComponent]
        public string Family { get; set; }

        [HttpQueryComponent]
        public int? Page { get; set; }

        [HttpQueryComponent]
        public int? PageSize { get; set; }

        #endregion
    }
}