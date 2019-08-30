#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Bimface.SDK.Entities.Core.Requests.DSL.Clauses;

#endregion

namespace Bimface.SDK.Entities.Core.Requests.DSL.Queries
{
    [DataContract]
    public class DSLQuery
    {
        #region Fields

        private IDictionary<string, IClause> _clauses = new Dictionary<string, IClause>();

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
        public IDictionary<string, IClause> Query
        {
            get => new Dictionary<string, IClause>(_clauses);
            set => _clauses = value.ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        [DataMember(Name = "targetIds")]
        public string[] TargetIds { get; private set; }

        [DataMember(Name = "targetType")]
        public string TargetType { get; private set; }

        #endregion

        #region Others

        /// <summary>
        ///     Add a clause to the <see cref="DSLQuery" />
        /// </summary>
        /// <param name="clause">The <see cref="IClause" /> instance</param>
        /// <returns>The <see cref="DSLQuery" /> itself</returns>
        public DSLQuery AddClause(IClause clause)
        {
            var name = clause.GetName();
            if (_clauses.ContainsKey(name))
                throw new ArgumentException("Same clause has already been added", nameof(clause));
            _clauses.Add(clause.GetName(), clause);
            return this;
        }

        #endregion
    }
}