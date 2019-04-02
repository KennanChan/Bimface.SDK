#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    [BimfaceAuth]
    public class LookupCompareTreeParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareTreeParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}