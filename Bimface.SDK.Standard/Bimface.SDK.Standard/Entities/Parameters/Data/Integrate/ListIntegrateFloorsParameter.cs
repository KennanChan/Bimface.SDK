#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateFloorsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFloorsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public bool? IncludeArea { get; set; }

        public bool? IncludeRoom { get; set; }

        #endregion
    }
}