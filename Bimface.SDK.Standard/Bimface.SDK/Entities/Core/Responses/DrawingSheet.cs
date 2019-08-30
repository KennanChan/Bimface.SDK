#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class DrawingSheet
    {
        #region Properties

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "portsAndViews")]
        public PortAndView[] PortsAndViews { get; set; }

        [DataMember(Name = "viewInfo")]
        public View ViewInfo { get; set; }

        #endregion
    }
}