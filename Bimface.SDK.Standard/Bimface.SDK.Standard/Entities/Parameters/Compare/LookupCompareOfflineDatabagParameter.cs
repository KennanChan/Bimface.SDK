#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class LookupCompareOfflineDatabagParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareOfflineDatabagParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}