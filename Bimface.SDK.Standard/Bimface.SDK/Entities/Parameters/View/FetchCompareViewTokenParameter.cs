#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.View
{
    public class FetchCompareViewTokenParameter : FetchViewTokenParameter
    {
        #region Constructors

        public FetchCompareViewTokenParameter(long compareId)
        {
            CompareId = compareId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long CompareId { get; }

        #endregion
    }
}