using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class LookupCompareParameter : CompareParameter, IBimfaceParameter
    {
        #region Constructors

        public LookupCompareParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Interface Implementations

        public string GetName()
        {
            return "lookup compare";
        }

        #endregion
    }
}