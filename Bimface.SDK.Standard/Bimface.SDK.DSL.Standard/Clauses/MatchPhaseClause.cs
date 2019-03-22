using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.Clauses
{
    [DataContract]
    public class MatchPhaseClause : Clause
    {
        [DataMember(Name = "match_phase")]
        public IReadOnlyDictionary<string, object> MatchPhase => GetData();
    }
}
