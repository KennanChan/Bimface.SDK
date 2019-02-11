namespace Bimface.SDK.Entities.Core
{
    public class UploadPolicyEntity
    {
        #region Properties

        public string AccessId { get; set; }
        public string CallbackBody { get; set; }
        public long? Expire { get; set; }
        public string Host { get; set; }
        public string ObjectKey { get; set; }
        public string Policy { get; set; }
        public string Signature { get; set; }
        public string SourceId { get; set; }

        #endregion
    }
}