#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.DSL
{
    [DataContract]
    public class ElementIdsResponse
    {
        #region Properties

        [DataMember(Name = "elementIds")]
        public object[] ElementIds { get; set; }

        [DataMember(Name = "targetId")]
        public string TargetId { get; set; }

        #endregion
    }
}