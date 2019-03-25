#region

using System.Runtime.Serialization;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class BusinessAssociationRequest : ICallbackSource, IConfigurable
    {
        #region Properties

        [DataMember(Name = "callback")] public string Callback { get; set; }

        [DataMember(Name = "config")] public object Config { get; set; }

        [DataMember(Name = "integrateId")] public long? IntegrateId { get; set; }

        [DataMember(Name = "name")] public string Name { get; set; }

        [DataMember(Name = "priority")] public int? Priority { get; set; }

        [DataMember(Name = "ruleFileIds")] public long?[] RuleFileIds { get; set; }

        #endregion
    }
}