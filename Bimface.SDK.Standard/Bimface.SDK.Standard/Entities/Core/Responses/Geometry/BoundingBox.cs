#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses.Geometry
{
    [DataContract]
    public class BoundingBox
    {
        #region Properties

        [DataMember(Name = "max")]
        public Coordinate Max { get; set; }

        [DataMember(Name = "min")]
        public Coordinate Min { get; set; }

        #endregion
    }
}