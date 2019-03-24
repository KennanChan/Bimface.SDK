using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFloorsParameter : IntegrateParameter
    {
        public ListIntegrateFloorsParameter(long integrateId) : base(integrateId)
        {
        }

        public bool? IncludeArea { get; set; }

        public bool? IncludeRoom { get; set; }
    }
}
