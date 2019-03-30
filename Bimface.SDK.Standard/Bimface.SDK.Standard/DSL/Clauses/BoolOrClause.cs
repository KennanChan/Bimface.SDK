#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class BoolOrClause : MultiClause
    {
        #region Constructors

        public BoolOrClause(params IClause[] clauses) : base(clauses)
        {
        }

        public BoolOrClause()
        {
        }

        #endregion

        #region Properties

        [DataMember(Name = "boolAnd")]
        public IReadOnlyCollection<IClause> Clauses => GetClauses();

        #endregion

        #region Others

        public override string GetName()
        {
            return "boolAnd";
        }

        #endregion
    }
}