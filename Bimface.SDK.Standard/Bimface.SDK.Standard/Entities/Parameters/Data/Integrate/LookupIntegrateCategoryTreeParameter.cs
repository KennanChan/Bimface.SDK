using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class LookupIntegrateCategoryTreeParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateCategoryTreeParameter(long integrateId, string roomId) : base(integrateId)
        {
            RoomId = roomId;
        }

        #endregion

        #region Properties

        public string RoomId { get; }

        #endregion
    }
}