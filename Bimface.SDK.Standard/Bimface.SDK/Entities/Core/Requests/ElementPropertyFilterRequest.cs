#region

using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Responses;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class ElementPropertyFilterRequest
    {
        #region Constructors

        public ElementPropertyFilterRequest(string[] elementIds)
        {
            ElementIds = elementIds;
        }

        #endregion

        #region Properties

        [DataMember(Name = "elementIds")]
        public string[] ElementIds { get; set; }

        [DataMember(Name = "filter")]
        public GroupAndKeysPair[] Filter { get; set; }

        #endregion
    }
}