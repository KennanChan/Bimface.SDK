#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/files")]
    public class ListIntegrateFilesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFilesParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? IncludeDrawingSheet { get; set; }

        #endregion
    }
}