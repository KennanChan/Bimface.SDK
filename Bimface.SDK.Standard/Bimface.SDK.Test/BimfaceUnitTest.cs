#region

using System.IO;
using Bimface.SDK.Entities;
using Bimface.SDK.Extensions;
using Newtonsoft.Json;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public abstract class BimfaceUnitTest<T>
    {
        #region Fields

        private Configuration _configuration;

        #endregion

        #region Constructors

        protected BimfaceUnitTest(ITestOutputHelper testOutputHelper)
        {
            Output  = testOutputHelper;
            Client  = BimfaceClient.GetOrCreate(new AppCredential(Configuration.AppKey, Configuration.AppSecret));
            Service = Client.GetService<T>();
        }

        #endregion

        #region Properties

        protected BimfaceClient Client { get; }

        protected Configuration Configuration =>
            _configuration ?? (_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(ConfigurationPath)));

        protected ITestOutputHelper Output  { get; }
        protected T                 Service { get; }

        /// <summary>
        ///     Assign the property to use another test configuration
        /// </summary>
        private string ConfigurationPath { get; } = @"C:\local\configuration.json";

        #endregion
    }
}