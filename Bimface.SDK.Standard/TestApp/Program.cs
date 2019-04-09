using System;
using System.Collections.Generic;
using Bimface.SDK;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Core.Requests.DSL.Clauses;
using Bimface.SDK.Entities.Core.Requests.DSL.Queries;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;

namespace TestApp
{
    internal class Program
    {
        private static void Main()
        {
            var client = BimfaceClient.GetOrCreate(new AppCredential("i6K9yCQqGh0OshxIoPDdOEou2HhFNnFn", "ZzMqkFGG3Enh0GcFkKsGyC8JV8nPwwzg"));
            DSL(client);
            Console.ReadKey();
        }

        private static void DSL(IServiceProvider client)
        {
            var query = new DSLFileQuery(new[] {"123456"})
                       .AddClause(new ContainClause(new Dictionary<string, object> {{"floor", "B01"}, {"familyType", "标准"}}))
                       .AddClause(new MatchClause("family", "family1"))
                       .AddClause(new BoolAndClause(new MatchClause("categoryId", "Id111"), new MatchClause("boundingBox.min.x", 167899.9999999998)))
                       .AddClause(new BoolOrClause(new MatchClause("productID", "KDKE-B-9947-#kL5"),
                            new BoolAndClause(new MatchClause("productID", "JODL-X-1937-#pV7"), new MatchClause("price", 30))));
            var json = client.GetService<IJsonSerializer>().Serialize(query);
            Console.WriteLine(json);
        }
    }
}