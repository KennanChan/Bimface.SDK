#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceAuth]
    public class ListCompareDiffParameter : CompareParameter
    {
        #region Constructors

        public ListCompareDiffParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        public string ElementName { get; set; }
        public string Family      { get; set; }
        public int?   Page        { get; set; }
        public int?   PageSize    { get; set; }

        #endregion
    }
}