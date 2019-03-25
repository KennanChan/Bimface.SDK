#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class PropertyGroup
    {
        #region Properties

        [DataMember(Name = "group")] public string Group { get; set; }

        [DataMember(Name = "items")] public PropertyItem[] Items { get; set; }

        #endregion
    }
}