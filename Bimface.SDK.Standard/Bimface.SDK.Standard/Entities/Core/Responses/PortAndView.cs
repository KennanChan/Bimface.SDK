#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class PortAndView
    {
        #region Properties

        [DataMember(Name = "elevation")]
        public double Elevation { get; set; }

        [DataMember(Name = "outline")]
        public double[] Outline { get; set; }

        [DataMember(Name = "viewId")]
        public string ViewId { get; set; }

        [DataMember(Name = "viewPoint")]
        public ViewPoint ViewPoint { get; set; }

        [DataMember(Name = "viewport")]
        public double[] Viewport { get; set; }

        [DataMember(Name = "viewType")]
        public string ViewType { get; set; }

        #endregion
    }
}