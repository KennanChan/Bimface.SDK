#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class DatabagInfo
    {
        #region Properties

        [DataMember(Name = "length")]
        public long? Length { get; set; }

        #endregion
    }
}