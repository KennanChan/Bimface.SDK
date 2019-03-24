using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bimface.SDK.DSL.Clauses
{
    public abstract class SingleClause : IClause
    {
        protected SingleClause(string name, object value)
        {
            _data = new Dictionary<string, object> { { name, value } };
        }

        private readonly IDictionary<string, object> _data;

        protected IReadOnlyDictionary<string, object> GetData()
        {
            if (_data == null)
                return null;
            return new ReadOnlyDictionary<string, object>(_data);
        }

        public abstract string GetName();
    }
}