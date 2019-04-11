#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Rfa
{
    [DataContract]
    public class RfaFamilyType
    {
        #region Properties

        [DataMember(Name = "familyTypeId")]
        public string FamilyTypeId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        #endregion
    }
}