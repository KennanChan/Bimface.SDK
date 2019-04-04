#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ElementPropertyOverride
    {
        #region Properties

        [DataMember(Name = "keyToMatch")]
        public string KeyToMatch { get; set; }

        [DataMember(Name = "keyToOverride")]
        public string KeyToOverride { get; set; }

        [DataMember(Name = "targetFileIds")]
        public long?[] TargetFileIds { get; set; }

        [DataMember(Name = "valueOverrides")]
        public ElementPropertyValueOverride[] ValueOverrides { get; set; }

        #endregion
    }
}