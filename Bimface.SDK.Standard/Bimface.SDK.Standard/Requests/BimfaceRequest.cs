using Bimface.SDK.Entities.Http;
using System;

namespace Bimface.SDK.Requests
{
    public abstract class BimfaceRequest : HttpRequest
    {
        #region Constructors

        protected BimfaceRequest(string method, string host, string api) : base(method, host, api)
        {
        }

        #endregion

        protected void AddDateQuery(string name, DateTime date)
        {
            AddQuery(name, date.ToString("yyyy-MM-dd"));
        }

        protected void AddNullableQuery<T>(string name, T? value) where T : struct
        {
            if (value.HasValue)
                AddQuery(name, value.Value.ToString());
        }
    }
}