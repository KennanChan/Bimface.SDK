namespace Bimface.SDK.Entities.Parameters.Base
{
    public abstract class IntegrateParameter
    {
        #region Constructors

        protected IntegrateParameter(long integrateId)
        {
            IntegrateId = integrateId;
        }

        #endregion

        #region Properties

        public long IntegrateId { get; }

        #endregion
    }
}