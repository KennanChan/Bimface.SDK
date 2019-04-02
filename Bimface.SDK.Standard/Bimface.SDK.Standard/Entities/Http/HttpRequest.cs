﻿#region

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Bimface.SDK.Attributes;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Entities.Http
{
    public class HttpRequest : IHttpRequest
    {
        #region Fields

        private ConcurrentDictionary<string, string> _headers;
        private ConcurrentDictionary<string, string> _queries;

        #endregion

        #region Constructors

        public HttpRequest(string method, string host, string api)
        {
            Method = method;
            Host   = host;
            Path   = api.StartsWith("/") ? api : $"/{api}";
        }

        #endregion

        #region Properties

        [Inject]
        protected IJsonSerializer Serializer { get; set; }

        private Stream Body { get; set; }

        private ConcurrentDictionary<string, string> Headers =>
            _headers ?? (_headers = new ConcurrentDictionary<string, string>());

        private string Host   { get; }
        private string Method { get; }
        private string Path   { get; }

        private ConcurrentDictionary<string, string> Queries =>
            _queries ?? (_queries = new ConcurrentDictionary<string, string>());

        #endregion

        #region Interface Implementations

        public Stream GetBody()
        {
            return Body;
        }

        public IDictionary<string, string> GetHeaders()
        {
            return Headers.ToDictionary(h => h.Key, h => h.Value);
        }

        public string GetMethod()
        {
            return Method;
        }

        public Uri GetUri()
        {
            var queryString = GetQueryString();
            return new Uri($"{Host}{Path}{(string.IsNullOrWhiteSpace(queryString) ? "" : "?")}{queryString}");
        }

        #endregion

        #region Others

        internal void AddBody(Stream stream)
        {
            Body = stream;
            SetContentLength(Body.Length);
        }

        internal void AddHeader(string name, string value)
        {
            Headers.AddOrUpdate(name, value, (n, v) => value);
        }

        internal void AddJsonBody(object body)
        {
            AddBody(Serializer.Serialize(body).ToStream());
            AddHeader("Content-Type", "application/json");
        }

        internal void AddQuery(string name, object value)
        {
            var valueString = GetValueString(value);
            Queries.AddOrUpdate(name, valueString, (n, v) => valueString);
        }

        internal string GetQueryString()
        {
            var queries =
                Queries
                   .Where(query => !string.IsNullOrWhiteSpace(query.Value))
                   .Select(query => $"{query.Key}={HttpUtility.UrlEncode(query.Value, Encoding.UTF8)}");
            return string.Join("&", queries);
        }

        internal void SetContentLength(long length)
        {
            AddHeader("Content-Length", length.ToString());
        }

        private string GetValueString(object value)
        {
            if (value.IsValueType())
            {
                if (value is DateTime time)
                    return time.ToString("yyyy-MM-dd");
            }

            return value?.ToString();
        }

        #endregion
    }
}