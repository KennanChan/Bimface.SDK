using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.Clauses
{
    [DataContract]
    public class MatchClause : Clause
    {
        [DataMember(Name = "match")]
        public IReadOnlyDictionary<string, object> Match => GetData();
    }
}
