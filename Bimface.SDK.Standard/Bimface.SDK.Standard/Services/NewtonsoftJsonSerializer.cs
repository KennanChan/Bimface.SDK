#region

using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;

#endregion

namespace Bimface.SDK.Services
{
    internal class NewtonsoftJsonSerializer : IJsonSerializer
    {
        #region Interface Implementations

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        #endregion
    }
}