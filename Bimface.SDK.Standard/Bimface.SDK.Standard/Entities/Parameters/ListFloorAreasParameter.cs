namespace Bimface.SDK.Entities.Parameters
{
    public class ListFloorAreasParameter : FileParameter
    {
        public ListFloorAreasParameter(long? fileId, string floorId) : base(fileId)
        {
            FloorId = floorId;
        }

        public string FloorId { get; }
    }
}