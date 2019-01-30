#region

using System;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ISourceFileService
    {
        FileEntity Upload(PushUploadParameter parameter, IProgress<long> progressReporter = null);
        FileEntity Upload(PullUploadParamter parameter);
    }
}