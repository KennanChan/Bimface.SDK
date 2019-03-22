#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
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