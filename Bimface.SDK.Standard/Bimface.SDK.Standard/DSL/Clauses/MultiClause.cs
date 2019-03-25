using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bimface.SDK.DSL.Clauses
{
    public abstract class MultiClause : IClause
    {
        #region Fields

        private readonly IList<IClause> _clauses;

        #endregion

        #region Constructors

        protected MultiClause(params IClause[] clauses)
        {
            _clauses = new List<IClause>(clauses);
        }

        protected MultiClause()
        {
            _clauses = new List<IClause>();
        }

        #endregion

        #region Interface Implementations

        public abstract string GetName();

        #endregion

        internal MultiClause AddClause(params IClause[] clauses)
        {
            clauses.ToList().ForEach(c => _clauses.Add(c));
            return this;
        }

        protected IReadOnlyCollection<IClause> GetClauses()
        {
            return new ReadOnlyCollection<IClause>(_clauses);
        }
    }
}