using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class BoolAndClause : MultiClause
    {
        #region Constructors

        public BoolAndClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolAndClause()
        {
        }

        #endregion

        #region Properties

        [DataMember(Name = "boolAnd")] public IReadOnlyCollection<IClause> Clauses => GetClauses();

        #endregion

        public override string GetName()
        {
            return "boolAnd";
        }
    }
}