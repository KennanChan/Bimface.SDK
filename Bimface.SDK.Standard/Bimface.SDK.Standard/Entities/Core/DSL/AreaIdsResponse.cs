#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.DSL
{
    [DataContract]
    public class AreaIdsResponse
    {
        #region Properties

        [DataMember(Name = "areaIds")]
        public object[] AreaIds { get; set; }

        [DataMember(Name = "targetId")]
        public string TargetId { get; set; }

        #endregion
    }
}