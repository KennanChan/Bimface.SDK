using Bimface.SDK.Interfaces.Infrastructure;
using System;

namespace Bimface.SDK.Services
{
    internal class DefaultJsonSerializer : IJsonSerializer
    {
        public T Deserialize<T>(string json)
        {
        }

        public string Serialize(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
