#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Core.Responses.Geometry;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ElementsWithBoundingBox
    {
        #region Properties

        [DataMember(Name = "boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [DataMember(Name = "elements")]
        public ElementIdWithFileId[] Elements { get; set; }

        #endregion
    }
}