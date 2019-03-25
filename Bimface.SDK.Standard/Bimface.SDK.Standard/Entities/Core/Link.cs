#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class Link
    {
        #region Properties

        [DataMember(Name = "guid")] public string Guid { get; set; }

        [DataMember(Name = "id")] public long? Id { get; set; }

        [DataMember(Name = "name")] public string Name { get; set; }

        [DataMember(Name = "transform")] public string Transform { get; set; }

        #endregion
    }
}