#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Bimface.SDK.DSL.Clauses;

#endregion

namespace Bimface.SDK.DSL
{
    [DataContract]
    public class DSLQuery
    {
        #region Fields

        private readonly IDictionary<string, IClause> _clauses = new Dictionary<string, IClause>();

        #endregion

        #region Constructors

        public DSLQuery(string targetType, string[] targetIds)
        {
            TargetType = targetType;
            TargetIds  = targetIds;
        }

        #endregion

        #region Properties

        [DataMember(Name = "query")]
        public IReadOnlyDictionary<string, IClause> Query => new ReadOnlyDictionary<string, IClause>(_clauses);

        [DataMember(Name = "targetIds")]
        public string[] TargetIds { get; }

        [DataMember(Name = "targetType")]
        public string TargetType { get; }

        #endregion

        #region Others

        public DSLQuery AddClause(IClause clause)
        {
            _clauses.Add(clause.GetName(), clause);
            return this;
        }

        #endregion
    }
}