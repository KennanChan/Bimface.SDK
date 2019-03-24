using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class BoolAndClause : MultiClause
    {
        public BoolAndClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolAndClause()
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