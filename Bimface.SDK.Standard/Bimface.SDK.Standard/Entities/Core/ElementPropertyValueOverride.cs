#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class ElementPropertyValueOverride
    {
        #region Properties

        [DataMember(Name = "valueToMatch")]
        public string ValueToMatch { get; set; }

        [DataMember(Name = "valueToOverride")]
        public string ValueToOverride { get; set; }

        #endregion
    }
}