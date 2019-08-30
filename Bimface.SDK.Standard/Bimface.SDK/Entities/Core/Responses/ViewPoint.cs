#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ViewPoint
    {
        #region Properties

        [DataMember(Name = "origin")]
        public double[] Origin { get; set; }

        [DataMember(Name = "rightDirection")]
        public double[] RightDirection { get; set; }

        [DataMember(Name = "scale")]
        public int? Scale { get; set; }

        [DataMember(Name = "upDirection")]
        public double[] UpDirection { get; set; }

        [DataMember(Name = "viewDirection")]
        public double[] ViewDirection { get; set; }

        #endregion
    }
}