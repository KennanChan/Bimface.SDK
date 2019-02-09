namespace Bimface.SDK.Entities.Parameters
{
    public class LookupElementPropertyParameter
    {
        public LookupElementPropertyParameter(long? fileId, string elementId)
        {
            FileId = fileId;
            ElementId = elementId;
        }

        public string ElementId { get; }
        public long? FileId { get; }
    }
}