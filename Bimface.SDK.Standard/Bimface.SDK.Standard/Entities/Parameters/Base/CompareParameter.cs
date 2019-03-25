namespace Bimface.SDK.Entities.Parameters.Base
{
    public abstract class CompareParameter
    {
        #region Constructors

        protected CompareParameter(long compareId)
        {
            CompareId = compareId;
        }

        #endregion

        #region Properties

        public long CompareId { get; }

        #endregion
    }
}