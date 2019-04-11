#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Property
    {
        #region Properties

        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [DataMember(Name = "elementId")]
        public string ElementId { get; set; }

        [DataMember(Name = "familyGuid")]
        public string FamilyGuid { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "properties")]
        public PropertyGroup[] Properties { get; set; }

        #endregion
    }
}