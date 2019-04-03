using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.DSL
{
    [DataContract]
    public class PropertyValuesResponse
    {
        [DataMember(Name = "property")]
        public string Property { get; set; }

        [DataMember(Name = "values")]
        public object[] Values { get; set; }
    }
}