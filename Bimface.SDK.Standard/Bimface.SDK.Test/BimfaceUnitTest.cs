#region

using System.IO;
using Bimface.SDK.Entities;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public abstract class BimfaceUnitTest
    {
        #region Fields

        private static Configuration _configuration;

        #endregion

        #region Constructors

        static BimfaceUnitTest()
        {
            Client = BimfaceClient.GetOrCreate(new AppCredential(Configuration.AppKey, Configuration.AppSecret));
        }

        protected BimfaceUnitTest(ITestOutputHelper testOutputHelper)
        {
            Output = testOutputHelper;
            Client.Singleton(testOutputHelper);
            Client.Singleton<ILogService, TestLogger>();
        }

        #endregion

        #region Properties

        protected static BimfaceClient Client { get; }

        protected static Configuration Configuration =>
            _configuration ?? (_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(ConfigurationPath)));

        /// <summary>
        ///     Assign the property to use another test configuration
        /// </summary>
        private static string ConfigurationPath { get; } = @"C:\local\configuration.json";

        protected ITestOutputHelper Output { get; }

        #endregion
    }
}