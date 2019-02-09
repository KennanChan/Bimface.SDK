using System;
using Bimface.SDK.Entities.Core.Geometry;

namespace Bimface.SDK.Entities.Core
{
    public class Property
    {
        public BoudingBox BoudingBox { get; set; }
        public string ElementId { get; set; }
        public string FamilyGuid { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public PropertyGroup[] Properties { get; set; }
    }
}
