#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFileViewsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFileViewsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public string ViewType { get; set; }

        #endregion
    }
}