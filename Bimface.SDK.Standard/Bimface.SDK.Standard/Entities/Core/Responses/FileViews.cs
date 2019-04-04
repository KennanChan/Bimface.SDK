using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Responses;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class FileViews
    {
        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        [DataMember(Name = "views")]
        public View[] Views { get; set; }
    }
}
