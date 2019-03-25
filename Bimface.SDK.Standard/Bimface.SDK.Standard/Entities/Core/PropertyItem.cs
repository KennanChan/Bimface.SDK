#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class PropertyItem
    {
        #region Properties

        [DataMember(Name = "code")] public string Code { get; set; }

        [DataMember(Name = "extension")] public object Extension { get; set; }

        [DataMember(Name = "key")] public string Key { get; set; }

        [DataMember(Name = "unit")] public string Unit { get; set; }

        [DataMember(Name = "value")] public object Value { get; set; }

        [DataMember(Name = "valueType")] public int? ValueType { get; set; }

        #endregion
    }
}