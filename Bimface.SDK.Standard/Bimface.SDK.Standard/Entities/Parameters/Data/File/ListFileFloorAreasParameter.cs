#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/areas")]
    public class ListFileFloorAreasParameter : FileParameter
    {
        #region Constructors

        public ListFileFloorAreasParameter(long fileId, string floorId) : base(fileId)
        {
            FloorId = floorId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string FloorId { get; }

        #endregion
    }
}