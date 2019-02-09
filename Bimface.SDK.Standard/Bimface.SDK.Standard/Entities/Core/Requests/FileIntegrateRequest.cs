using System.Collections.Generic;

namespace Bimface.SDK.Entities.Core
{
  public class FileIntegrateRequest
  {
        public string Callback { get; set; }
        public string Config { get; set; }
        public FloorMappingItem[] FloorMapping { get; set; }
        public string[] FlootSort { get; set; }
        public IDictionary<string,string> InternalConfigMap { get; set; }
        public string Name { get; set; }
        public long? ParentIntegrateId { get; set; }
        public int? Priority { get; set; }
        public ElementPropertyOverride[] PropertyOverrides { get; set; }
        public object[] RuleFileIds { get; set; }
        public string SourceId { get; set; }
        public IntegrateSource[] Sources { get; set; }
        public string[] SpecialtySort { get; set; }
    }
}