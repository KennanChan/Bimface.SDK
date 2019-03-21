using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data
{
    public class ListFileFloorAreasParameter : FileParameter
    {
        #region Constructors

        public ListFileFloorAreasParameter(long fileId, string floorId) : base(fileId)
        {
            FloorId = floorId;
        }

        #endregion

        #region Properties

        public string FloorId { get; }

        #endregion
    }
}