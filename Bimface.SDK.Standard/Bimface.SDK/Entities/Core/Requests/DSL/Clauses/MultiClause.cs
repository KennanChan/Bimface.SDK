#region

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Bimface.SDK.Entities.Core.Requests.DSL.Clauses
{
    public abstract class MultiClause : List<IDictionary<string, IClause>>, IClause
    {
        #region Constructors

        protected MultiClause(params IClause[] clauses) : base(Convert(clauses))
        {
        }

        protected MultiClause()
        {
        }

        #endregion

        #region Interface Implementations

        public abstract string GetName();

        #endregion

        #region Others

        private static IEnumerable<IDictionary<string, IClause>> Convert(IEnumerable<IClause> clauses)
        {
            return clauses.Select(clause => new Dictionary<string, IClause> {{clause.GetName(), clause}});
        }

        public MultiClause AddClause(params IClause[] clauses)
        {
            AddRange(Convert(clauses));
            return this;
        }

        #endregion
    }
}