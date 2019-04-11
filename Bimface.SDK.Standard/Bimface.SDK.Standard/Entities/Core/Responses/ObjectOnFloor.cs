#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ObjectOnFloor
    {
        #region Properties

        [DataMember(Name = "boundary")]
        public string Boundary { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "levelId")]
        public string LevelId { get; set; }

        [DataMember(Name = "maxPt")]
        public Coordinate MaxPoint { get; set; }

        [DataMember(Name = "minPt")]
        public Coordinate MinPoint { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        #endregion
    }
}