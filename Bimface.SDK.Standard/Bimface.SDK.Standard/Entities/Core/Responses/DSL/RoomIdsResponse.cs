#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses.DSL
{
    [DataContract]
    public class RoomIdsResponse
    {
        #region Properties

        [DataMember(Name = "roomIds")]
        public object[] RoomIds { get; set; }

        [DataMember(Name = "targetId")]
        public string TargetId { get; set; }

        #endregion
    }
}