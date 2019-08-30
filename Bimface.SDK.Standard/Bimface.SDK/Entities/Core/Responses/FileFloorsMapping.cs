using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class FileFloorsMapping
    {
        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        [DataMember(Name = "floors")]
        public Floor[] Floors { get; set; }
    }
}