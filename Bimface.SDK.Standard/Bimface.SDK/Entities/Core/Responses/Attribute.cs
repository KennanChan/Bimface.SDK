#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Attribute
    {
        #region Properties

        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "unit")]
        public string Unit { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        #endregion
    }
}