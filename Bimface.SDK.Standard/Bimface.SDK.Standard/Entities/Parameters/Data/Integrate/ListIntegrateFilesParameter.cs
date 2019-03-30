#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFilesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFilesParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public bool? IncludeDrawingSheet { get; set; }

        #endregion
    }
}