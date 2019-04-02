#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class DeleteCompareParameter : CompareParameter
    {
        #region Constructors

        public DeleteCompareParameter(long compareId) : base(compareId)
        {
        }

        #endregion
    }
}