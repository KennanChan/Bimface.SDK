namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementMaterialsParameter
    {
        public string ElementId { get; }
        public long? FileId { get; }

        public ListElementMaterialsParameter(long? fileId, string elementId)
        {
            FileId = fileId;
            ElementId = elementId;
        }
    }
}
