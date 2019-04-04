#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Area
    {
        #region Properties

        [DataMember(Name = "area")]
        public double AreaValue { get; set; }

        [DataMember(Name = "boundary")]
        public string Boundary { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "levelId")]
        public string LevelId { get; set; }

        [DataMember(Name = "maxPt")]
        public Coordinate MaxPt { get; set; }

        [DataMember(Name = "minPt")]
        public Coordinate MinPt { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "perimeter")]
        public double Perimeter { get; set; }

        [DataMember(Name = "properties")]
        public PropertyGroup[] Properties { get; set; }

        [DataMember(Name = "viewName")]
        public string ViewName { get; set; }

        #endregion
    }
}