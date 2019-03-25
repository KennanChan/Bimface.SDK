using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class DeleteCompareParameter : CompareParameter, IBimfaceParameter
    {
        #region Constructors

        public DeleteCompareParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Interface Implementations

        public string GetName()
        {
            return "delete-compare";
        }

        #endregion
    }
}