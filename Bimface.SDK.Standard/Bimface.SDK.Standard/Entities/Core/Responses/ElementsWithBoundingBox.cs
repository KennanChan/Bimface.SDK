using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;
using Bimface.SDK.Entities.Core.Requests;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ElementsWithBoundingBox
    {
        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [DataMember(Name = "elements")]
        public ElementIdWithFileId[] Elements { get; set; }
    }
}