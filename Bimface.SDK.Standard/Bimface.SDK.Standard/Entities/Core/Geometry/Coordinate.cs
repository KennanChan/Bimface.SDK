#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Geometry
{
    [DataContract]
    public class Coordinate
    {
        #region Properties

        [DataMember(Name = "x")]
        public double X { get; set; }

        [DataMember(Name = "y")]
        public double Y { get; set; }

        [DataMember(Name = "z")]
        public double Z { get; set; }

        #endregion
    }
}