#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class TranslateSource
    {
        public TranslateSource(long? fileId, string rootName, bool compressed)
        {
            Compressed = compressed;
            FileId     = fileId;
            RootName   = rootName;
        }

        #region Properties

        [DataMember(Name = "compressed")]
        public bool Compressed { get; set; }

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "rootName")]
        public string RootName { get; set; }

        #endregion
    }
}