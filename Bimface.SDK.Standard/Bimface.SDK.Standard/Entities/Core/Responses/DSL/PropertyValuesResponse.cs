#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses.DSL
{
    [DataContract]
    public class PropertyValuesResponse
    {
        #region Properties

        [DataMember(Name = "property")]
        public string Property { get; set; }

        [DataMember(Name = "values")]
        public object[] Values { get; set; }

        #endregion
    }
}