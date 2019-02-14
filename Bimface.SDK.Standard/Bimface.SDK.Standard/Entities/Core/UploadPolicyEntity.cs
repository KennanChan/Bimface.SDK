using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class UploadPolicyEntity
    {
        #region Properties

        [DataMember(Name = "accessId")]
        public string AccessId { get; set; }

        [DataMember(Name = "callbackBody")]
        public string CallbackBody { get; set; }

        [DataMember(Name = "expire")]
        public long? Expire { get; set; }

        [DataMember(Name = "host")]
        public string Host { get; set; }

        [DataMember(Name = "objectKey")]
        public string ObjectKey { get; set; }

        [DataMember(Name = "policy")]
        public string Policy { get; set; }

        [DataMember(Name = "signature")]
        public string Signature { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        #endregion
    }
}