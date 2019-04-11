#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ElementIdWithBoundingBox
    {
        #region Properties

        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [DataMember(Name = "elementId")]
        public string ElementId { get; set; }

        #endregion
    }
}