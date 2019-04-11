#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests.DSL.Clauses
{
    [DataContract]
    public class ContainClause : Dictionary<string, object>, IClause
    {
        #region Constructors

        public ContainClause(IDictionary<string, object> dictionary) : base(dictionary)
        {
        }

        public ContainClause()
        {
        }

        #endregion

        #region Interface Implementations

        public string GetName()
        {
            return "contain";
        }

        #endregion
    }
}