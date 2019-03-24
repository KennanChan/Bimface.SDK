using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFileViewsParameter : IntegrateParameter
    {
        public ListIntegrateFileViewsParameter(long integrateId) : base(integrateId)
        {
        }

        public string ViewType { get; set; }
    }
}
