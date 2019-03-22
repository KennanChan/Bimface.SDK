using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.Clauses
{
    [DataContract]
    public class RangeClause : Clause
    {
        [DataMember(Name = "range")]
        public IReadOnlyDictionary<string, object> Range => GetData();
    }
}
