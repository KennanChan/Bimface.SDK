using Bimface.SDK.Entities.Core.Geometry;

namespace Bimface.SDK.Entities.Core
{
    public class AreaInfo
    {
        public double Area { get; set; }
        public string Boundary { get; set; }
        public string Id { get; set; }
        public string LevelId { get; set; }
        public Coordinate MaxPt { get; set; }
        public Coordinate MinPt { get; set; }
        public string Name { get; set; }
        public double Perimeter { get; set; }
        public PropertyGroup[] Properties { get; set; }
        public string ViewName { get; set; }
    }
}
