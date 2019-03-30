#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class GroupAndKeysPair
    {
        #region Properties

        [DataMember(Name = "group")]
        public string Group { get; set; }

        [DataMember(Name = "keys")]
        public string[] Keys { get; set; }

        #endregion
    }
}