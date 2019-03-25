#region

using System.Collections.Generic;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class Room
    {
        #region Properties

        [DataMember(Name = "area")] public double Area { get; set; }

        [DataMember(Name = "boundary")] public string Boundary { get; set; }

        [DataMember(Name = "bboxMax")] public Coordinate BoundingBoxMax { get; set; }

        [DataMember(Name = "bboxMin")] public Coordinate BoundingBoxMin { get; set; }

        [DataMember(Name = "id")] public string Id { get; set; }

        [DataMember(Name = "levelId")] public string LevelId { get; set; }

        [DataMember(Name = "maxPt")] public Coordinate MaxPoint { get; set; }

        [DataMember(Name = "minPt")] public Coordinate MinPoint { get; set; }

        [DataMember(Name = "name")] public string Name { get; set; }

        [DataMember(Name = "perimeter")] public double Perimeter { get; set; }

        [DataMember(Name = "properties")] public List<PropertyGroup> Properties { get; set; }

        #endregion
    }
}