using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class ModelCompareRequest
    {
        #region Properties

        [DataMember(Name = "callback")] public string Callback { get; set; }
        [DataMember(Name = "name")] public string Name { get; set; }
        [DataMember(Name = "priority")] public int? Priority { get; set; }
        [DataMember(Name = "sourceId")] public string SourceId { get; set; }
        [DataMember(Name = "sources")] public ModelCompareItem[] Sources { get; set; }

        #endregion
    }
}