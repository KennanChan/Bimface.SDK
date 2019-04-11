#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests.DSL.Clauses
{
    [DataContract]
    public class MatchClause : ReadOnlyDictionary<string, object>, IClause
    {
        #region Constructors

        public MatchClause(string name, object value) : base(new Dictionary<string, object> {{name, value}})
        {
        }

        #endregion

        #region Interface Implementations

        public string GetName()
        {
            return "match";
        }

        #endregion
    }
}