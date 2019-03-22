namespace Bimface.SDK.Entities.Core.Requests
{
    public class FileIdHashWithElementIdsRequest
    {
        public object[] ElementIds { get; set; }
        public string   FileIdHash { get; set; }
    }
}