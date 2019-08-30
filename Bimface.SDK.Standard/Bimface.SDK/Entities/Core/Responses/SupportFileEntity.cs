#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
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