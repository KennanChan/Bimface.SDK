using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.Clauses
{
    [DataContract]
    public class TermClause : Clause
    {
        [DataMember(Name = "term")]
        public IReadOnlyDictionary<string, object> Term => GetData();
    }
}