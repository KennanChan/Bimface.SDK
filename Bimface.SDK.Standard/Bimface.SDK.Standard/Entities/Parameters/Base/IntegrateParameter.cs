namespace Bimface.SDK.Entities.Parameters.Base
{
    public abstract class IntegrateParameter
    {
        protected IntegrateParameter(long integrateId)
        {
            IntegrateId = integrateId;
        }

        public long IntegrateId { get; }
    }
}