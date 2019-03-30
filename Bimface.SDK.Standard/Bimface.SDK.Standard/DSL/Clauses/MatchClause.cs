#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class MatchClause : SingleClause
    {
        #region Constructors

        public MatchClause(string name, object value) : base(name, value)
        {
        }

        #endregion

        #region Properties

        [DataMember(Name = "match")]
        public IReadOnlyDictionary<string, object> Match => GetData();

        #endregion

        #region Others

        public override string GetName()
        {
            return "match";
        }

        #endregion
    }
}