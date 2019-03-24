namespace Bimface.SDK.Entities.Parameters.Base
{
    public abstract class CompareParameter
    {
        protected CompareParameter(long compareId)
        {
            CompareId = compareId;
        }
        public long CompareId { get; }
    }
}
