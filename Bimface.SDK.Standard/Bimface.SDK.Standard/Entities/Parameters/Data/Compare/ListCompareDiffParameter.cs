using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    public class ListCompareDiffParameter : CompareParameter
    {
        public ListCompareDiffParameter(long compareId) : base(compareId)
        {
        }

        public string ElementName { get; set; }
        public string Family      { get; set; }
        public int?   Page        { get; set; }
        public int?   PageSize    { get; set; }
    }
}