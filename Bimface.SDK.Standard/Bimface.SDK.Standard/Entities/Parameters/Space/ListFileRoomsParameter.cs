using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Space
{
    public class ListFileRoomsParameter : FileParameter
    {
        #region Constructors

        public ListFileRoomsParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        public string ElementId { get; set; }
        public string FloorId { get; set; }
        public Tolerance RoomToleranceXY { get; set; }
        public Tolerance RoomToleranceZ { get; set; }

        #endregion
    }
}