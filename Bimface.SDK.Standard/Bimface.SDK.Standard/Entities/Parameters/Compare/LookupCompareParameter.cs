#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class LookupCompareParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}