#region

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Bimface.SDK.Entities.Core.Common;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IJsonSerializer" /> using the built-in
    ///     <see cref="DataContractJsonSerializer" />
    /// </summary>
    internal class DefaultJsonSerializer : IJsonSerializer
    {
        #region Properties

        private static ConcurrentDictionary<Type, DataContractJsonSerializer> Serializers { get; } =
            new ConcurrentDictionary<Type, DataContractJsonSerializer>();
#if NET40
#else
        private DataContractJsonSerializerSettings Settings { get; }
            = new DataContractJsonSerializerSettings
              {
                  DateTimeFormat            = new DateTimeFormat(Constants.DateFormat),
                  UseSimpleDictionaryFormat = true
              };
#endif

        #endregion

        #region Interface Implementations

        /// <summary>
        ///     Deserialize a json string to an object of type <see cref="T" />
        /// </summary>
        /// <typeparam name="T">A type</typeparam>
        /// <param name="string">A json string</param>
        /// <returns>An instance of type <see cref="T" /></returns>
        public T Deserialize<T>(string @string)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(@string)))
            {
                var serializer = GetSerializer(typeof(T));
                return (T) serializer.ReadObject(stream);
            }
        }

        /// <summary>
        ///     Serialize an object to a json string
        /// </summary>
        /// <param name="obj">An instance of the object to serialize</param>
        /// <returns>A json string</returns>
        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var stream = new MemoryStream())
                {
                    var serializer = GetSerializer(obj.GetType());
                    serializer.WriteObject(stream, obj);
                    stream.Position = 0;
                    while (true)
                    {
                        var remainLength = stream.Length - stream.Position;
                        if (remainLength > 1024)
                            remainLength = 1024;
                        var buffer = new byte[remainLength];
                        if (stream.Read(buffer, 0, (int) remainLength) > 0)
                            stringWriter.Write(Encoding.UTF8.GetString(buffer));
                        else
                            break;
                    }
                }

                return stringWriter.ToString();
            }
        }

        #endregion

        #region Others

        private DataContractJsonSerializer GetSerializer(Type type)
        {
#if NET40
            return Serializers.GetOrAdd(type, t => new DataContractJsonSerializer(t));
#else
            return Serializers.GetOrAdd(type,
                t => new DataContractJsonSerializer(t, Settings));
#endif
        }

        #endregion
    }
}