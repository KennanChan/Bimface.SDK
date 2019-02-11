using Bimface.SDK.Entities.Core.Geometry;
using System.Collections.Generic;

namespace Bimface.SDK.Entities.Core
{
    public class Room
    {
        #region Properties

        public double Area { get; set; }
        public Coordinate BboxMax { get; set; }
        public Coordinate BboxMin { get; set; }
        public string Boundary { get; set; }
        public string Id { get; set; }
        public string LevelId { get; set; }
        public Coordinate MaxPt { get; set; }
        public Coordinate MinPt { get; set; }
        public string Name { get; set; }
        public double Perimeter { get; set; }
        public List<PropertyGroup> Properties { get; set; }

        #endregion
    }
}