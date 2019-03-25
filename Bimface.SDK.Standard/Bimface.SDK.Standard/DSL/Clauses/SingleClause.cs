using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bimface.SDK.DSL.Clauses
{
    public abstract class SingleClause : IClause
    {
        #region Fields

        private readonly IDictionary<string, object> _data;

        #endregion

        #region Constructors

        protected SingleClause(string name, object value)
        {
            _data = new Dictionary<string, object> {{name, value}};
        }

        #endregion

        #region Interface Implementations

        public abstract string GetName();

        #endregion

        protected IReadOnlyDictionary<string, object> GetData()
        {
            if (_data == null)
                return null;
            return new ReadOnlyDictionary<string, object>(_data);
        }
    }
}