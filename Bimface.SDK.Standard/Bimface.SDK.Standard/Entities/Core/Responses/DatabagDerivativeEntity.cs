#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class DatabagDerivativeEntity
    {
        #region Properties

        [DataMember(Name = "createTime")]
        public DateTime CreateTime { get; set; }

        [DataMember(Name = "databagVersion")]
        public string DatabagVersion { get; set; }

        [DataMember(Name = "length")]
        public long? Length { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        #endregion
    }
}