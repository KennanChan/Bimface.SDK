namespace Bimface.SDK.Entities.Parameters
{
    public class ListFloorAreasParameter : FileParameter
    {
        #region Constructors

        public ListFloorAreasParameter(long? fileId, string floorId) : base(fileId)
        {
            FloorId = floorId;
        }

        #endregion

        #region Properties

        public string FloorId { get; }

        #endregion
    }
}