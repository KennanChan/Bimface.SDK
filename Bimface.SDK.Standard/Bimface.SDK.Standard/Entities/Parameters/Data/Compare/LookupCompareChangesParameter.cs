#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceDataApiHttpRequest("/comparisons/{comparisonId}/elementChange")]
    public class LookupCompareChangesParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareChangesParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string FollowingElementId { get; set; }

        [HttpQueryComponent]
        public long? FollowingFileId { get; set; }

        [HttpQueryComponent]
        public string PreviousElementId { get; set; }

        [HttpQueryComponent]
        public long? PreviousFileId { get; set; }

        #endregion
    }
}