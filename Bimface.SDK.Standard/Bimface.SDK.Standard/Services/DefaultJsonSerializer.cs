#region

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Services
{
    internal class DefaultJsonSerializer : IJsonSerializer
    {
        #region Interface Implementations

        public T Deserialize<T>(string @string)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(new StringReader(@string).ReadToEnd())))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T) serializer.ReadObject(stream);
            }
        }

        public string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                using (var stream = new MemoryStream())
                {
                    var serializer = new DataContractJsonSerializer(obj.GetType());
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
    }
}