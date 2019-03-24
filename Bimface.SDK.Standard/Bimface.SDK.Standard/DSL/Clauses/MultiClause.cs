using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bimface.SDK.DSL.Clauses
{
    public abstract class MultiClause : IClause
    {
        private readonly IList<IClause> _clauses;

        protected MultiClause(params IClause[] clauses)
        {
            _clauses = new List<IClause>(clauses);
        }

        protected MultiClause()
        {
            _clauses = new List<IClause>();
        }

        internal MultiClause AddClause(params IClause[] clauses)
        {
            clauses.ToList().ForEach(c => _clauses.Add(c));
            return this;
        }

        protected IReadOnlyCollection<IClause> GetClauses()
        {
            return new ReadOnlyCollection<IClause>(_clauses);
        }

        public abstract string GetName();
    }
}