﻿#region

using System;
using System.Collections.Generic;
using System.Linq;
using Bimface.SDK.Entities.Http;

#endregion

namespace Bimface.SDK.Requests.Base
{
    public abstract class BimfaceRequest : HttpRequest
    {
        #region Constructors

        protected BimfaceRequest(string method, string host, string api) : base(method, host, api)
        {
        }

        #endregion

        #region Others

        protected void AddArrayQuery<T>(string name, IEnumerable<T> value) where T : class
        {
            var items = value.ToList();
            if (items.Count > 0) items.ForEach(item => AddQuery(name, item));
        }

        protected void AddDateQuery(string name, DateTime date)
        {
            AddQuery(name, date.ToString("yyyy-MM-dd"));
        }

        protected void AddNullableArrayQuery<T>(string name, IEnumerable<T?> value) where T : struct
        {
            var items = value.ToList();
            if (items.Count > 0) items.ForEach(item => AddNullableQuery(name, item));
        }

        protected void AddNullableQuery<T>(string name, T? value) where T : struct
        {
            if (value.HasValue)
                AddQuery(name, value.Value.ToString());
        }

        protected void AddQuery<T>(string name, T value)
        {
            base.AddQuery(name, value.ToString());
        }

        #endregion
    }
}