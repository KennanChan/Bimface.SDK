using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class SupportFileEntity
    {
        #region Properties

        [DataMember(Name = "length")]
        public long? Length { get; set; }

        [DataMember(Name = "types")]
        public object[] Types { get; set; }

        #endregion
    }
}