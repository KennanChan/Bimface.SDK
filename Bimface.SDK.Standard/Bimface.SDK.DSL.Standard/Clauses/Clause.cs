using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bimface.SDK.Clauses
{
    public abstract class Clause
    {
        private readonly IDictionary<string, object> _data = new Dictionary<string, object>();

        public void SetData(string name, object value)
        {
            _data.Clear();
            _data.Add(name, value);
        }

        protected IReadOnlyDictionary<string, object> GetData()
        {
            if (_data == null)
                return null;
            return new ReadOnlyDictionary<string, object>(_data);
        }
    }
}