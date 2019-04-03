using System;
using Bimface.SDK;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;

namespace TestAppFx
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = BimfaceClient.Create(new AppCredential("i6K9yCQqGh0OshxIoPDdOEou2HhFNnFn", "ZzMqkFGG3Enh0GcFkKsGyC8JV8nPwwzg"));
            //client.Singleton<IJsonSerializer, JsonSerializer>();
            var shareService = client.GetService<IShareService>();
            shareService.ListShares(new ListSharesParameter()).ContinueWith(task1 =>
            {
                shareService.ListShares(new ListSharesParameter()).ContinueWith(task2 => { });
            });
            Console.ReadKey();
        }
    }
}