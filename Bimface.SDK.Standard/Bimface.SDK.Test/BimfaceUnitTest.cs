#region

using System;
using System.IO;
using Bimface.SDK.Entities;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public abstract class BimfaceUnitTest : IDisposable
    {
        #region Fields

        private static Configuration _configuration;

        #endregion

        #region Constructors

        static BimfaceUnitTest()
        {
            Client = BimfaceClient.GetOrCreate(new AppCredential(Configuration.AppKey, Configuration.AppSecret));
            Client.Singleton<ILogService>(new TestLogger(null));
        }

        protected BimfaceUnitTest(ITestOutputHelper testOutputHelper)
        {
            OriginalOut = Console.Out;
            Output      = testOutputHelper;
            var logger = new TestLogger(testOutputHelper);
            Console.SetOut(logger);
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

        private TextWriter OriginalOut { get; }

        #endregion

        #region Interface Implementations

        public void Dispose()
        {
            Console.SetOut(OriginalOut);
        }

        #endregion

        //protected async Task BootstrapTest(Func<Task> test)
        //{
        //    Client.AddService<ILogService>(() => new TestLogger(Output));
        //    if (null != test)
        //        await test.Invoke();
        //}

        //protected async Task BootstrapTest(Task task)
        //{
        //    Client.AddService<ILogService>(() => new TestLogger(Output));
        //    await task;
        //}
    }
}