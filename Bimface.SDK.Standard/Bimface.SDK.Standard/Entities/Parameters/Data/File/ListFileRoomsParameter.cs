#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/rooms")]
    public class ListFileRoomsParameter : FileParameter
    {
        #region Constructors

        public ListFileRoomsParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string ElementId { get; set; }

        [HttpQueryComponent]
        public string FloorId { get; set; }

        [HttpQueryComponent]
        public Tolerance RoomToleranceXY { get; set; }

        [HttpQueryComponent]
        public Tolerance RoomToleranceZ { get; set; }

        #endregion
    }
}