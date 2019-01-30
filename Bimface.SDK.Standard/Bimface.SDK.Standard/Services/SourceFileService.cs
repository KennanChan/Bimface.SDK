#region

using System;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class SourceFileService : ISourceFileService
    {
        #region Constructors

        #endregion

        #region Interface Implementations

        public FileEntity Upload(PushUploadParameter parameter, IProgress<long> progressReporter = null)
        {
            throw new NotImplementedException();
        }

        public FileEntity Upload(PullUploadParamter parameter)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}