using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class ElementPropertyFilterRequest
    {
        #region Properties

        [DataMember(Name = "elementIds")]
        public string[] ElementIds { get; set; }

        [DataMember(Name = "filter")]
        public GroupAndKeysPair[] Filter { get; set; }

        #endregion
    }
}