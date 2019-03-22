using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFilesParameter : IntegrateParameter
    {
        public ListIntegrateFilesParameter(long integrateId) : base(integrateId)
        {
        }

        public bool? IncludeDrawingSheet { get; set; }
    }
}
