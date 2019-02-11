﻿#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ISourceFileService
    {
        Task<AppendFileEntity> CreateAppendFile(CreateAppendFileParameter parameter);
        Task<UploadPolicyEntity> CreateUploadPolicy(FetchUploadPolicyParameter parameter);
        Task DeleteFile(DeleteFileParameter parameter);
        Task<AppendFileEntity> FetchAppendFile(FetchAppendFileParameter parameter);
        Task<string> FetchFileTemporaryDownloadUrl(FileDownloadAddressParameter parameter);
        Task<List<FileEntity>> ListFiles(ListFilesParameter parameter);
        Task<FileEntity> LookupFileMeta(LookupFileMetaParameter parameter);
        Task<AppendFileEntity> ResumeAppendFile(ResumeAppendFileParameter parameter);
        Task<FileEntity> Upload(PushUploadParameter parameter, IProgress<long> progressReporter = null);
        Task<FileEntity> Upload(PullUploadParameter parameter);
        Task<SupportFileEntity> ViewSupportFileTypes();
    }
}