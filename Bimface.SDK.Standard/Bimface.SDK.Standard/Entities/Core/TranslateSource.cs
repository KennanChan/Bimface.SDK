#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class TranslateSource
    {
        #region Properties

        [DataMember(Name = "compressed")] public bool Compressed { get; set; }

        [DataMember(Name = "fileId")] public long? FileId { get; set; }

        [DataMember(Name = "rootName")] public string RootName { get; set; }

        #endregion
    }
}