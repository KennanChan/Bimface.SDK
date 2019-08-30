#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Responses;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class FileViews
    {
        #region Properties

        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        [DataMember(Name = "views")]
        public View[] Views { get; set; }

        #endregion
    }
}