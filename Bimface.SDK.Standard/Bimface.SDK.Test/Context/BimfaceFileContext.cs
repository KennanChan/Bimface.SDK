#region

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test.Context
{
    public class BimfaceFileContext : IDisposable
    {
        #region Fields

        private static Configuration _configuration;
        private        FileEntity[]  _integrateModels;
        private        FileEntity    _singleModelFile;

        #endregion

        #region Constructors

        public BimfaceFileContext()
        {
            Client = BimfaceClient.GetOrCreate(new AppCredential(Configuration.AppKey, Configuration.AppSecret));
            FileService = Client.GetService<IFileService>();
        }

        #endregion

        #region Properties

        protected static Configuration Configuration =>
            _configuration ?? (_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(ConfigurationPath)));

        /// <summary>
        ///     Assign the property to use another test configuration
        /// </summary>
        private static string ConfigurationPath { get; } = @"C:\local\configuration.json";

        public BimfaceClient Client { get; }

        public FileEntity[] IntegrateModels => _integrateModels ??
                                               (_integrateModels =
                                                    Task.WhenAll(Configuration.LocalIntegrateRevitFilePaths.Select(path =>
                                                        FileService.Upload(new PushUploadParameter(path)))).Result);

        public FileEntity SingleModelFile => _singleModelFile ??
                                             (_singleModelFile = FileService
                                                                .Upload(new PullUploadParameter(Configuration.RemoteRevitFileName,
                                                                     Configuration.RemoteRevitFileUrl)).Result);

        private IFileService FileService { get; }

        public void SetOutput(ITestOutputHelper output)
        {

        }

        #endregion

        #region Interface Implementations

        public async void Dispose()
        {
        }

        #endregion
    }
}