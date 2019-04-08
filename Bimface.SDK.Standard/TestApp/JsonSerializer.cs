﻿using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;

namespace TestApp
{
    internal class JsonSerializer : IJsonSerializer
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}