#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    public class DeleteIntegrateParameter : IntegrateParameter
    {
        public DeleteIntegrateParameter(long integrateId) : base(integrateId)
        {
        }
    }
}