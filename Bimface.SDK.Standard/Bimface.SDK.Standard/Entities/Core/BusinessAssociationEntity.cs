#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class BusinessAssociationEntity
    {
        #region Properties

        [DataMember(Name = "associationId")]
        public long? AssociationId { get; set; }

        [DataMember(Name = "config")]
        public object Config { get; set; }

        [DataMember(Name = "createTime")]
        public DateTime CreateTime { get; set; }

        [DataMember(Name = "integrateId")]
        public long? IntegrateId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "ruleFileIds")]
        public long?[] RuleFileIds { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        #endregion
    }
}