#region

using System.Collections.Generic;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Responses;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class FileIntegrateRequest
    {
        #region Properties

        [DataMember(Name = "callback")]
        public string Callback { get; set; }

        [DataMember(Name = "config")]
        public string Config { get; set; }

        [DataMember(Name = "floorMapping")]
        public FloorMappingItem[] FloorMapping { get; set; }

        [DataMember(Name = "floorSort")]
        public string[] FloorSort { get; set; }

        [DataMember(Name = "internalConfigMap")]
        public IDictionary<string, string> InternalConfigMap { get; set; } = new Dictionary<string, string>();

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "parentIntegrateId")]
        public long? ParentIntegrateId { get; set; } 

        [DataMember(Name = "priority")]
        public int Priority { get; set; } = 2;

        [DataMember(Name = "propertyOverrides")]
        public ElementPropertyOverride[] PropertyOverrides { get; set; }

        [DataMember(Name = "ruleFileIds")]
        public object[] RuleFileIds { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        [DataMember(Name = "sources")]
        public IntegrateSource[] Sources { get; set; }

        [DataMember(Name = "specialtySort")]
        public string[] SpecialtySort { get; set; }

        #endregion
    }
}