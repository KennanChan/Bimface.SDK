using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class BoolOrClause : MultiClause
    {
        public BoolOrClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolOrClause()
        {

        }

        [DataMember(Name = "boolAnd")]
        public IReadOnlyCollection<IClause> Clauses => GetClauses();

        public override string GetName()
        {
            return "boolAnd";
        }
    }
}