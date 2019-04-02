using System;
using Bimface.SDK;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = BimfaceClient.GetOrCreate(new AppCredential("i6K9yCQqGh0OshxIoPDdOEou2HhFNnFn", "ZzMqkFGG3Enh0GcFkKsGyC8JV8nPwwzg"));
            client.Singleton<IJsonSerializer, JsonSerializer>();

            var shareService = client.GetService<IShareService>();
            shareService.GetShares(new ListSharesParameter()).ContinueWith(task =>
            {
                var result = task.Result;
                Console.WriteLine(client.GetService<IJsonSerializer>().Serialize(result));
            });
            Console.ReadKey();
        }
    }
}