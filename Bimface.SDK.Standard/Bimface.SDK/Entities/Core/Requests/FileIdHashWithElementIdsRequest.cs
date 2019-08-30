#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class FileIdHashWithElementIdsRequest
    {
        #region Properties

        [DataMember(Name = "elementIds")]
        public object[] ElementIds { get; set; }

        [DataMember(Name = "fileIdHash")]
        public string FileIdHash { get; set; }

        #endregion
    }
}