namespace Bimface.SDK.Entities.Parameters
{
    public class LookupAreaParameter : FileParameter
    {
        public LookupAreaParameter(long? fileId, string areaId) : base(fileId)
        {
            AreaId = areaId;
        }

        public string AreaId { get; }
    }
}