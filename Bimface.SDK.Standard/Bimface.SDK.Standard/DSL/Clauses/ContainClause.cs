#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.DSL.Clauses
{
    [DataContract]
    public class ContainClause : SingleClause
    {
        #region Constructors

        public ContainClause(string name, object value) : base(name, value)
        {
        }

        #endregion

        #region Properties

        [DataMember(Name = "contain")]
        public IReadOnlyDictionary<string, object> Contain => GetData();

        #endregion

        #region Others

        public override string GetName()
        {
            return "contain";
        }

        #endregion
    }
}