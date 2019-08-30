#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class MaterialInfo
    {
        #region Properties

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "parameters")]
        public PropertyGroup[] Parameters { get; set; }

        #endregion
    }
}