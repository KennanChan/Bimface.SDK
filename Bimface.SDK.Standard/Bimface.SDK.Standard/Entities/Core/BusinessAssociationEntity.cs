#region

using System;

#endregion

namespace Bimface.SDK.Entities.Core
{
    public class BusinessAssociationEntity
    {
        #region Properties

        public long? AssociationId { get; set; }
        public object Config { get; set; }
        public DateTime CreateTime { get; set; }
        public long? IntegrateId { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string Reason { get; set; }
        public long?[] RuleFileIds { get; set; }
        public string SourceId { get; set; }
        public string Status { get; set; }

        #endregion
    }
}